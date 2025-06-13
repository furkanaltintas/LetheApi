using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SocialMediasController(IGenericRepository<SocialMedia> socialMediaRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSocialMedias()
    {
        IEnumerable<SocialMedia> socialMedias = await socialMediaRepository.GetAllAsync();
        if (!socialMedias.Any()) return NotFound("No social media information found.");
        return Ok(socialMedias);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia([FromBody] SocialMedia socialMedia)
    {
        if (socialMedia == null) return BadRequest("Invalid social media information.");
        await socialMediaRepository.AddAsync(socialMedia);
        return CreatedAtAction(nameof(GetSocialMedias), new { id = socialMedia.Id }, socialMedia);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSocialMedia(int id, [FromBody] SocialMedia socialMedia)
    {
        if (socialMedia == null || socialMedia.Id != id) return BadRequest("Invalid social media information.");
        SocialMedia? existingSocialMedia = await socialMediaRepository.GetByIdAsync(id);
        if (existingSocialMedia == null) return NotFound("Social media information not found.");
        socialMediaRepository.Update(socialMedia);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSocialMedia(int id)
    {
        SocialMedia? existingSocialMedia = await socialMediaRepository.GetByIdAsync(id);
        if (existingSocialMedia == null) return NotFound("Social media information not found.");
        socialMediaRepository.Delete(existingSocialMedia);
        return NoContent();
    }
}