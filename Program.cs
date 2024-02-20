using ScreenSound_Consumes_API.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        musics?.ForEach(music => music.ShowMusicDetails());
        Console.WriteLine(musics?.Count);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema! {ex.Message}");
    }
}