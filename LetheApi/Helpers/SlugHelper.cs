using System.Text.RegularExpressions;

namespace LetheApi.Helpers;

public static class SlugHelper
{
    public static String GenerateSlug(string text)
    {
        text = text.ToLowerInvariant();
        text = Regex.Replace(text, @"[^a-z0-9\s-]", ""); // özel karakterleri kaldırır
        text = Regex.Replace(text, @"\s+", " ").Trim(); // fazla boşlukları azaltır
        text = Regex.Replace(text, @"\s", "-"); // boşlukları tireye çevir
        return text;
    }
}
