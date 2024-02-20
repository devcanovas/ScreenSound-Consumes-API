using ScreenSound_Consumes_API.Models;

namespace ScreenSound_Consumes_API.Filters;

internal class LinqOrder
{
    public static void ShowArtistsOrdered(List<Music> musics)
    {
        List<string?> artistsOrdered = musics.OrderBy(music => music.Artist)
            .Select(music => music.Artist)
            .Distinct()
            .ToList();
        artistsOrdered.ForEach(artist => Console.WriteLine($"- {artist}"));
    }
}
