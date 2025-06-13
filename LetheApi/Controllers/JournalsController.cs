using LetheApi.Helpers;
using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JournalsController(IGenericRepository<Journal> journalRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetJournals()
    {
        IEnumerable<Journal> journals = await journalRepository.GetAllAsync();
        foreach (var journal in journals)
        {
            journal.Slug = SlugHelper.GenerateSlug(journal.Title);
            journalRepository.Update(journal);
            journalRepository.SaveChanges();
        }
        return Ok(journals);
    }

    [HttpGet("similar/{id}")]
    public async Task<IActionResult> GetSimilar(int id, [FromQuery] int count = 3)
    {
        var current = await journalRepository.GetByIdAsync(id);
        if (current == null) return NotFound("Journal not found.");

        var others = await journalRepository.Query()
                                            .Where(j => j.Id != id)
                                            .OrderByDescending(j => Guid.NewGuid())
                                            .Take(count)
                                            .ToListAsync();

        return Ok(others);
    }

    [HttpGet("blog/{slug}")]
    public async Task<IActionResult> GetBySlug([FromRoute] String slug)
    {
        Journal? journal = await journalRepository.GetByAsync(j => j.Slug == slug);
        if (journal == null) return NotFound("Journal not found.");
        return Ok(journal);
    }

    [HttpGet("navigation/{id}")]
    public async Task<IActionResult> GetNavigation(int id)
    {
        var current = await journalRepository.GetByIdAsync(id);
        if (current == null) return NotFound("Journal not found");

        var previous = await journalRepository.Query()
                                              .Where(j => j.Id < id)
                                              .OrderByDescending(j => j.Id)
                                              .FirstOrDefaultAsync();

        var next = await journalRepository.Query()
                                          .Where(j => j.Id > id)
                                          .OrderBy(j => j.Id)
                                          .FirstOrDefaultAsync();

        return Ok(new
        {
            previous = previous is null ? null : new { previous.Id, previous.Title, previous.Slug },
            next = next is null ? null : new { next.Id, next.Title, next.Slug },
        });
    }

    [HttpPost]
    public async Task<IActionResult> CreateJournal([FromBody] Journal journal)
    {
        if (journal == null) return BadRequest("Invalid journal information.");
        journal.Slug = SlugHelper.GenerateSlug(journal.Title);
        await journalRepository.AddAsync(journal);
        return CreatedAtAction(nameof(GetJournals), new { id = journal.Id }, journal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateJournal(int id, [FromBody] Journal journal)
    {
        if (journal == null || journal.Id != id) return BadRequest("Invalid journal information.");
        Journal? existingJournal = await journalRepository.GetByIdAsync(id);
        if (existingJournal == null) return NotFound("Journal not found.");
        journalRepository.Update(journal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteJournal(int id)
    {
        Journal? existingJournal = await journalRepository.GetByIdAsync(id);
        if (existingJournal == null) return NotFound("Journal not found.");
        journalRepository.Delete(existingJournal);
        return NoContent();
    }
}