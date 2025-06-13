using LetheApi.Models;
using LetheApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LetheApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonialContentsController(IGenericRepository<TestimonialContent> testimonialContentRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTestimonialContent()
    {
        TestimonialContent? testimonialContent = await testimonialContentRepository.GetFirstAsync();
        if(testimonialContent == null) return NotFound("Testimonial Content not found.");
        return Ok(testimonialContent);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTestimonialContent([FromBody] TestimonialContent testimonialContent)
    {
        if (testimonialContent == null) return BadRequest("Invalid testimonial content.");
        await testimonialContentRepository.AddAsync(testimonialContent);
        return CreatedAtAction(nameof(GetTestimonialContent), new { id = testimonialContent.Id }, testimonialContent);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTestimonialContent(int id, [FromBody] TestimonialContent testimonialContent)
    {
        if (testimonialContent == null || testimonialContent.Id != id) return BadRequest("Invalid testimonial content.");
        TestimonialContent? existingTestimonial = await testimonialContentRepository.GetByIdAsync(id);
        if (existingTestimonial == null) return NotFound("Testimonial content not found.");
        testimonialContentRepository.Update(testimonialContent);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTestimonialContent(int id)
    {
        TestimonialContent? existingTestimonial = await testimonialContentRepository.GetByIdAsync(id);
        if (existingTestimonial == null) return NotFound("Testimonial content not found.");
        testimonialContentRepository.Delete(existingTestimonial);
        return NoContent();
    }
}