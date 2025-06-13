using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactContentsController(IGenericRepository<ContactContent> contactContentRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetContactContent()
    {
        ContactContent? contactContent = await contactContentRepository.GetFirstAsync();
        if (contactContent == null) return NotFound("Contact content not found.");
        return Ok(contactContent);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContactContent([FromBody] ContactContent contactContent)
    {
        if (contactContent == null) return BadRequest("Invalid contact content data.");
        await contactContentRepository.AddAsync(contactContent);
        await contactContentRepository.SaveChangesAsync();
        return CreatedAtAction(nameof(GetContactContent), new { id = contactContent.Id }, contactContent);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContactContent(int id, [FromBody] ContactContent contactContent)
    {
        if (contactContent == null || contactContent.Id != id) return BadRequest("Invalid contact content data.");
        ContactContent? existingContact = await contactContentRepository.GetByIdAsync(id);
        if (existingContact == null) return NotFound("Contact content not found.");
        contactContentRepository.Update(contactContent);
        await contactContentRepository.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContactContent(int id)
    {
        ContactContent? existingContact = await contactContentRepository.GetByIdAsync(id);
        if (existingContact == null) return NotFound("Contact content not found.");
        contactContentRepository.Delete(existingContact);
        await contactContentRepository.SaveChangesAsync();
        return NoContent();
    }
}