using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IntrosController(IGenericRepository<Intro> introRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetIntro()
    {
        Intro? intro = await introRepository.GetFirstAsync();
        if (intro == null) return NotFound("Intro information not found.");
        return Ok(intro);
    }

    [HttpPost]
    public async Task<IActionResult> CreateIntro([FromBody] Intro intro)
    {
        if (intro == null) return BadRequest("Invalid intro information.");
        await introRepository.AddAsync(intro);
        return CreatedAtAction(nameof(GetIntro), new { id = intro.Id }, intro);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateIntro(int id, [FromBody] Intro intro)
    {
        if (intro == null || intro.Id != id) return BadRequest("Invalid intro information.");
        Intro? existingIntro = await introRepository.GetByIdAsync(id);
        if (existingIntro == null) return NotFound("Intro information not found.");
        introRepository.Update(intro);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteIntro(int id)
    {
        Intro? existingIntro = await introRepository.GetByIdAsync(id);
        if (existingIntro == null) return NotFound("Intro information not found.");
        introRepository.Delete(existingIntro);
        return NoContent();
    }
}