using System.Text.Json.Serialization;

namespace ScreenSound_Consumes_API.Models;

internal class Movie
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("crew")]
    public string? Crew { get; set; }

    [JsonPropertyName("fullTitle")]
    public string? FullTitle { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    public void ShowMovieDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Crew: {Crew}");
        Console.WriteLine($"Full Title: {FullTitle}");
        Console.WriteLine($"Year: {Year}\n");
    }
}
