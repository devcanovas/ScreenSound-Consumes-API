using System.Text.Json;

namespace ScreenSound_Consumes_API.Models;

internal class Playlist(string Name)
{
    public string Name { get; set; } = Name;
    public List<Music> Musics { get; } = [];

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }

    public void GetPlaylistDetails()
    {
        Console.WriteLine($"Nome da playlist: {Name}\n");
        Console.WriteLine("Músicas adicionadas:");
        Musics.ForEach(music => Console.WriteLine($"- {music.Name}"));
    }

    public void GenerateJSON()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = Musics
        });
        string archieveName = $"playlist-{Name}.json";

        File.WriteAllText(archieveName, json);
        Console.WriteLine($"JSON gerado com sucesso! {Path.GetFullPath(archieveName)}");
    }
}
