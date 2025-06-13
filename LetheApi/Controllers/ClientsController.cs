using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController(IGenericRepository<Client> clientRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        IEnumerable<Client> clients = await clientRepository.GetAllAsync();
        return Ok(clients);
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient([FromBody] Client client)
    {
        if (client == null) return BadRequest("Invalid client information.");
        await clientRepository.AddAsync(client);
        return CreatedAtAction(nameof(GetClients), new { id = client.Id }, client);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClient(int id, [FromBody] Client client)
    {
        if (client == null || client.Id != id) return BadRequest("Invalid client information.");
        Client? existingClient = await clientRepository.GetByIdAsync(id);
        if (existingClient == null) return NotFound("Client not found.");
        clientRepository.Update(client);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClient(int id)
    {
        Client? existingClient = await clientRepository.GetByIdAsync(id);
        if (existingClient == null) return NotFound("Client not found.");
        clientRepository.Delete(existingClient);
        return NoContent();
    }
}