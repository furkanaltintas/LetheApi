using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CtasController(IGenericRepository<Cta> ctaRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCta()
    {
        Cta? cta = await ctaRepository.GetFirstAsync();
        if (cta == null) return NotFound("CTA not found.");
        return Ok(cta);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCta([FromBody] Cta cta)
    {
        if (cta == null) return BadRequest("Invalid CTA information.");
        await ctaRepository.AddAsync(cta);
        return CreatedAtAction(nameof(GetCta), new { id = cta.Id }, cta);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCta(int id, [FromBody] Cta cta)
    {
        if (cta == null || cta.Id != id) return BadRequest("Invalid CTA information.");
        Cta? existingCta = await ctaRepository.GetByIdAsync(id);
        if (existingCta == null) return NotFound("CTA not found.");
        ctaRepository.Update(cta);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCta(int id)
    {
        Cta? existingCta = await ctaRepository.GetByIdAsync(id);
        if (existingCta == null) return NotFound("CTA not found.");
        ctaRepository.Delete(existingCta);
        return NoContent();
    }
}