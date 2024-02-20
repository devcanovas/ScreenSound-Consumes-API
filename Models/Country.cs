using System.Text.Json.Serialization;

namespace ScreenSound_Consumes_API.Models;

internal class Country
{
    [JsonPropertyName("nome")]
    public string? Name { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    public void ShowCountryDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Capital: {Capital}");
    }
}
