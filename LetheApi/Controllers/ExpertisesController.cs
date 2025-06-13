using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpertisesController(IGenericRepository<Expertise> expertiseRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetExpertises()
    {
        IEnumerable<Expertise> expertises = await expertiseRepository.GetAllAsync();
        return Ok(expertises);
    }

    [HttpPost]
    public async Task<IActionResult> CreateExpertise([FromBody] Expertise expertise)
    {
        if (expertise == null) return BadRequest("Invalid expertise information.");
        await expertiseRepository.AddAsync(expertise);
        return CreatedAtAction(nameof(GetExpertises), new { id = expertise.Id }, expertise);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateExpertise(int id, [FromBody] Expertise expertise)
    {
        if (expertise == null || expertise.Id != id) return BadRequest("Invalid expertise information.");
        Expertise? existingExpertise = await expertiseRepository.GetByIdAsync(id);
        if (existingExpertise == null) return NotFound("Expertise information not found.");
        expertiseRepository.Update(expertise);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExpertise(int id)
    {
        Expertise? existingExpertise = await expertiseRepository.GetByIdAsync(id);
        if (existingExpertise == null) return NotFound("Expertise information not found.");
        expertiseRepository.Delete(existingExpertise);
        return NoContent();
    }
}