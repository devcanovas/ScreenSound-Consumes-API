using ScreenSound_Consumes_API.Models;
using System.Text.Json;

HttpClient client = new();
async Task RequestMusicAsync()
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        musics?.ForEach(music => music.ShowMusicDetails());
        Console.WriteLine(musics?.Count);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema! {ex.Message}");
    }
}

async Task RequestMovieAsync()
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(response)!;
        movies?.ForEach(movie => movie.ShowMovieDetails());
        Console.WriteLine(movies?.Count);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Ops! tivemos um problema {e.Message}");
    }
}

await RequestMovieAsync();