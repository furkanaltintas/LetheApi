namespace LetheApi.Models;

public class Expertise
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string[] ListService { get; set; } = [];
}