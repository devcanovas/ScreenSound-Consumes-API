using System.Text.Json.Serialization;

namespace ScreenSound_Consumes_API.Models;

internal class Music
{

    private string[] TONALITIES = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; }

    public string Tonality
    {
        get
        {
            return TONALITIES[Key];
        }
    }


    public void ShowMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Durantion: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Tonality: {Tonality}");
    }
}
