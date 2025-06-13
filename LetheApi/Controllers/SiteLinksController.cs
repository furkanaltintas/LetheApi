using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SiteLinksController(IGenericRepository<SiteLink> siteLinkRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSiteLinks()
    {
        IEnumerable<SiteLink> siteLinks = await siteLinkRepository.GetAllAsync();
        return Ok(siteLinks);
    }
    [HttpPost]
    public async Task<IActionResult> CreateSiteLink([FromBody] SiteLink siteLink)
    {
        if (siteLink == null) return BadRequest("Invalid site link information.");
        await siteLinkRepository.AddAsync(siteLink);
        return CreatedAtAction(nameof(GetSiteLinks), new { id = siteLink.Id }, siteLink);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSiteLink(int id, [FromBody] SiteLink siteLink)
    {
        if (siteLink == null || siteLink.Id != id) return BadRequest("Invalid site link information.");
        SiteLink? existingSiteLink = await siteLinkRepository.GetByIdAsync(id);
        if (existingSiteLink == null) return NotFound("Site link not found.");
        siteLinkRepository.Update(siteLink);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSiteLink(int id)
    {
        SiteLink? existingSiteLink = await siteLinkRepository.GetByIdAsync(id);
        if (existingSiteLink == null) return NotFound("Site link not found.");
        siteLinkRepository.Delete(existingSiteLink);
        return NoContent();
    }
}