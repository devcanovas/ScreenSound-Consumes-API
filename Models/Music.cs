using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace ScreenSound_Consumes_API.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public void ShowMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Durantion: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
