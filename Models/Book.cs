using System.Text.Json.Serialization;

namespace ScreenSound_Consumes_API.Models;

internal class Book
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("autor")]
    public string? Author { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public string? Year { get; set; }

    public void ShowBookDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year: {Year}");
    }
}
