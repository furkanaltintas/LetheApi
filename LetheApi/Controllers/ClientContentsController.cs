using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientContentsController(IGenericRepository<ClientContent> clientContentRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetClientContent()
    {
        ClientContent? clientContents = await clientContentRepository.GetFirstAsync();
        if (clientContents == null) return NotFound("Client Content information not found.");
        return Ok(clientContents);
    }

    [HttpPost]
    public async Task<IActionResult> CreateClientContent([FromBody] ClientContent clientContent)
    {
        if (clientContent == null) return BadRequest("Invalid client content.");
        await clientContentRepository.AddAsync(clientContent);
        return CreatedAtAction(nameof(GetClientContent), new { id = clientContent.Id }, clientContent);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClientContent(int id, [FromBody] ClientContent clientContent)
    {
        if (clientContent == null || clientContent.Id != id) return BadRequest("Invalid client content.");
        ClientContent? existingClientContent = await clientContentRepository.GetByIdAsync(id);
        if (existingClientContent == null) return NotFound("Client content not found.");
        clientContentRepository.Update(clientContent);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClientContent(int id)
    {
        ClientContent? existingClientContent = await clientContentRepository.GetByIdAsync(id);
        if (existingClientContent == null) return NotFound("Client content not found.");
        clientContentRepository.Delete(existingClientContent);
        return NoContent();
    }
}