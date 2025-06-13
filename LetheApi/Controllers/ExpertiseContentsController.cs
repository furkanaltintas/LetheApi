using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpertiseContentsController(IGenericRepository<ExpertiseContent> expertiseContentRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetExpertiseContent()
    {
        ExpertiseContent? expertiseContent = await expertiseContentRepository.GetFirstAsync();
        if (expertiseContent == null) return NotFound("Expertise Content information not found.");
        return Ok(expertiseContent);
    }

    [HttpPost]
    public async Task<IActionResult> CreateExpertiseContent([FromBody] ExpertiseContent expertiseContent)
    {
        if (expertiseContent == null) return BadRequest("Invalid expertise content information.");
        await expertiseContentRepository.AddAsync(expertiseContent);
        return CreatedAtAction(nameof(GetExpertiseContent), new { id = expertiseContent.Id }, expertiseContent);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateExpertiseContent(int id, [FromBody] ExpertiseContent expertiseContent)
    {
        if (expertiseContent == null || expertiseContent.Id != id) return BadRequest("Invalid expertise content information.");
        ExpertiseContent? existingExpertiseContent = await expertiseContentRepository.GetByIdAsync(id);
        if (existingExpertiseContent == null) return NotFound("Expertise Content information not found.");
        expertiseContentRepository.Update(expertiseContent);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExpertiseContent(int id)
    {
        ExpertiseContent? existingExpertiseContent = await expertiseContentRepository.GetByIdAsync(id);
        if (existingExpertiseContent == null) return NotFound("Expertise Content information not found.");
        expertiseContentRepository.Delete(existingExpertiseContent);
        return NoContent();
    }
}