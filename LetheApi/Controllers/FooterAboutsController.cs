using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FooterAboutsController(IGenericRepository<FooterAbout> footerAboutRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetFooterAbout()
    {
        FooterAbout? footerAbout = await footerAboutRepository.GetFirstAsync();
        if (footerAbout == null) return NotFound("Footer about information not found.");
        return Ok(footerAbout);
    }
    [HttpPost]
    public async Task<IActionResult> CreateFooterAbout([FromBody] FooterAbout footerAbout)
    {
        if (footerAbout == null) return BadRequest("Invalid footer about information.");
        await footerAboutRepository.AddAsync(footerAbout);
        return CreatedAtAction(nameof(GetFooterAbout), new { id = footerAbout.Id }, footerAbout);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateFooterAbout(int id, [FromBody] FooterAbout footerAbout)
    {
        if (footerAbout == null || footerAbout.Id != id) return BadRequest("Invalid footer about information.");
        FooterAbout? existingFooterAbout = await footerAboutRepository.GetByIdAsync(id);
        if (existingFooterAbout == null) return NotFound("Footer about information not found.");
        footerAboutRepository.Update(footerAbout);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFooterAbout(int id)
    {
        FooterAbout? existingFooterAbout = await footerAboutRepository.GetByIdAsync(id);
        if (existingFooterAbout == null) return NotFound("Footer about information not found.");
        footerAboutRepository.Delete(existingFooterAbout);
        return NoContent();
    }
}