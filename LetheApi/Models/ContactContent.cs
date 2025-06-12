namespace LetheApi.Models;

public class ContactContent
{
    public int Id { get; set; }
    public string ImagePath { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ButtonText { get; set; } = string.Empty;
    public string SocialMediaText { get; set; } = string.Empty;
    public string EmailText { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string PhoneText { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}
