namespace LetheApi.Models;

public class  Testimonial
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Profession { get; set; } = string.Empty;
}
