using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JournalContentsController(IGenericRepository<JournalContent> journalContentRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetJournalContent()
    {
        JournalContent? journalContent = await journalContentRepository.GetFirstAsync();
        if (journalContent == null) return NotFound("Journal content not found.");
        return Ok(journalContent);
    }
    [HttpPost]
    public async Task<IActionResult> CreateJournalContent([FromBody] JournalContent journalContent)
    {
        if (journalContent == null) return BadRequest("Invalid journal content.");
        await journalContentRepository.AddAsync(journalContent);
        return CreatedAtAction(nameof(GetJournalContent), new { id = journalContent.Id }, journalContent);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateJournalContent(int id, [FromBody] JournalContent journalContent)
    {
        if (journalContent == null || journalContent.Id != id) return BadRequest("Invalid journal content.");
        JournalContent? existingJournalContent = await journalContentRepository.GetByIdAsync(id);
        if (existingJournalContent == null) return NotFound("Journal content not found.");
        journalContentRepository.Update(journalContent);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteJournalContent(int id)
    {
        JournalContent? existingJournalContent = await journalContentRepository.GetByIdAsync(id);
        if (existingJournalContent == null) return NotFound("Journal content not found.");
        journalContentRepository.Delete(existingJournalContent);
        return NoContent();
    }
}