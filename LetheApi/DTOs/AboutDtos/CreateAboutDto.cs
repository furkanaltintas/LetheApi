namespace LetheApi.DTOs.AboutDtos;

public class CreateAboutDto
{
    public string Title { get; set; } = string.Empty;
    public string DisplayTitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ButtonText { get; set; } = "More About Me";
    public string? ButtonUrl { get; set; } = "/about";
    public string ImageUrl { get; set; } = string.Empty;
    public string MainTitle { get; set; } = string.Empty;
    public string MainDescription { get; set; } = string.Empty;
}
