using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CopyrightsController(IGenericRepository<Copyright> copyrightRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCopyright()
    {
        Copyright? copyright = await copyrightRepository.GetFirstAsync();
        if (copyright == null) return NotFound("Copyright information not found.");
        return Ok(copyright);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCopyright([FromBody] Copyright copyright)
    {
        if (copyright == null) return BadRequest("Invalid copyright information.");
        await copyrightRepository.AddAsync(copyright);
        return CreatedAtAction(nameof(GetCopyright), new { id = copyright.Id }, copyright);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCopyright(int id, [FromBody] Copyright copyright)
    {
        if (copyright == null || copyright.Id != id) return BadRequest("Invalid copyright information.");
        Copyright? existingCopyright = await copyrightRepository.GetByIdAsync(id);
        if (existingCopyright == null) return NotFound("Copyright information not found.");
        copyrightRepository.Update(copyright);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCopyright(int id)
    {
        Copyright? existingCopyright = await copyrightRepository.GetByIdAsync(id);
        if (existingCopyright == null) return NotFound("Copyright information not found.");

        copyrightRepository.Delete(existingCopyright);
        return NoContent();
    }
}