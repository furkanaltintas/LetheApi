namespace LetheApi.Models;

public class Cta
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ButtonText { get; set; } = string.Empty;
    public string ButtonUrl { get; set; } = string.Empty;
}
