using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AboutsController(IGenericRepository<About> aboutRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAbout()
    {
        About? about = await aboutRepository.GetFirstAsync();
        if (about == null) return NotFound("About information not found.");
        return Ok(about);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout([FromBody] About about)
    {
        if (about == null) return BadRequest("Invalid about information.");
        await aboutRepository.AddAsync(about);
        return CreatedAtAction(nameof(GetAbout), new { id = about.Id }, about);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAbout(int id, [FromBody] About about)
    {
        if (about == null || about.Id != id) return BadRequest("Invalid about information.");

        About? existingAbout = await aboutRepository.GetByIdAsync(id);
        if (existingAbout == null) return NotFound("About information not found.");
        aboutRepository.Update(about);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAbout(int id)
    {
        About? existingAbout = await aboutRepository.GetByIdAsync(id);
        if (existingAbout == null) return NotFound("About information not found.");

        aboutRepository.Delete(existingAbout);
        return NoContent();
    }
}