using ScreenSound_Consumes_API.Models;

namespace ScreenSound_Consumes_API.Filters;

internal class LinqFilter
{
    public static void FilterAllGenreInMusics(List<Music> musics)
    {
        List<string?> allGenres = musics.Select(genres => genres.Genre)
            .Distinct()
            .ToList();
        allGenres.ForEach(genre => { Console.WriteLine($"- {genre}"); });
    }

    public static void FilterArtistsByGenre(List<Music> musics, string genre)
    {
        List<string?> artists = musics.Where(music => music.Genre!.Contains(genre))
            .Select(music => music.Artist)
            .Distinct()
            .ToList();
        artists.ForEach(artist => Console.WriteLine($"- {artist}"));
    }

    public static void FilterMusicsByArtist(List<Music> musics, string artistName)
    {
        List<Music> artistsMusics = musics.Where(music => music.Artist!.Equals(artistName)).ToList();
        Console.WriteLine($"Filtrando músicas pelo artista: {artistName}");
        artistsMusics.ForEach(music => Console.WriteLine($"- {music.Name}"));
    }

    public static void FilterMusicsByCSharp(List<Music> musics)
    {
        List<string?> musicsFiltered = musics
                    .Where(music => music.Tonality.Equals("C#"))
                    .Select(music => music.Name)
                    .ToList(); ;
        Console.WriteLine("Músicas em C#: ");
        musicsFiltered.ForEach(music => Console.WriteLine($"- {music}"));
    }
}
