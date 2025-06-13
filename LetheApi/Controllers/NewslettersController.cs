using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NewslettersController(IGenericRepository<Newsletter> newsletterRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetNewsletter()
    {
        Newsletter? newsletter = await newsletterRepository.GetFirstAsync();
        if (newsletter == null) return NotFound("Newsletter information not found.");
        return Ok(newsletter);
    }
    [HttpPost]
    public async Task<IActionResult> CreateNewsletter([FromBody] Newsletter newsletter)
    {
        if (newsletter == null) return BadRequest("Invalid newsletter information.");
        await newsletterRepository.AddAsync(newsletter);
        return CreatedAtAction(nameof(GetNewsletter), new { id = newsletter.Id }, newsletter);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNewsletter(int id)
    {
        Newsletter? existingNewsletter = await newsletterRepository.GetByIdAsync(id);
        if (existingNewsletter == null) return NotFound("Newsletter not found.");
        newsletterRepository.Delete(existingNewsletter);
        return NoContent();
    }
}