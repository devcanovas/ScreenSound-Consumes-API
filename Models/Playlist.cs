namespace ScreenSound_Consumes_API.Models;

internal class Playlist(string Name)
{
    public string Name { get; set; } = Name;
    public List<Music> musics { get; } = [];

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void GetPlaylistDetails()
    {
        Console.WriteLine($"Nome da playlist: {Name}\n");
        Console.WriteLine("Músicas adicionadas:");
        musics.ForEach(music => Console.WriteLine($"- {music.Name}"));
    }
}
