namespace LetheApi.Models;

public class ExpertiseContent
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string DisplayTitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ButtonText { get; set; } = string.Empty;
    public string ButtonUrl { get; set; } = string.Empty;
}
