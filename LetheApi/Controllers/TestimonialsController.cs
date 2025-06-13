using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonialsController(IGenericRepository<Testimonial> testimonialRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTestimonials()
    {
        IEnumerable<Testimonial> testimonials = await testimonialRepository.GetAllAsync();
        return Ok(testimonials);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTestimonial([FromBody] Testimonial testimonial)
    {
        if (testimonial == null) return BadRequest("Invalid testimonial information.");
        await testimonialRepository.AddAsync(testimonial);
        return CreatedAtAction(nameof(GetTestimonials), new { id = testimonial.Id }, testimonial);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTestimonial(int id, [FromBody] Testimonial testimonial)
    {
        if (testimonial == null || testimonial.Id != id) return BadRequest("Invalid testimonial information.");
        Testimonial? existingTestimonial = await testimonialRepository.GetByIdAsync(id);
        if (existingTestimonial == null) return NotFound("Testimonial not found.");
        testimonialRepository.Update(testimonial);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        Testimonial? existingTestimonial = await testimonialRepository.GetByIdAsync(id);
        if (existingTestimonial == null) return NotFound("Testimonial not found.");
        testimonialRepository.Delete(existingTestimonial);
        return NoContent();
    }
}