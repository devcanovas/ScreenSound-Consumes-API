using ScreenSound_Consumes_API.Models;
using System.Net;
using System.Text.Json;

HttpClient client = new();
async Task RequestMusicsAsync()
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        handleResponseMusic(response);
    }
    catch (Exception e)
    {
        handleException(e);
    }
}

async Task RequestMoviesAsync()
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        handleResponseMovies(response);
    }
    catch (Exception e)
    {
        handleException(e);
    }
}

async Task RequestCountriesAsync()
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        handleResponseCountries(response);
    }
    catch (Exception e)
    {
        handleException(e);
    }
}



void handleResponseCountries(string response)
{
    List<Country> countries = JsonSerializer.Deserialize<List<Country>>(response)!;
    countries?.ForEach(country => country.ShowCountryDetails());
    Console.WriteLine(countries?.Count);
}
void handleException(Exception e)
{
    Console.WriteLine($"Ops! houve um problema inesperado: {e.Message}");
}

static void handleResponseMusic(string response)
{
    List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response)!;
    musics?.ForEach(music => music.ShowMusicDetails());
    Console.WriteLine(musics?.Count);
}

static void handleResponseMovies(string response)
{
    List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(response)!;
    movies?.ForEach(movie => movie.ShowMovieDetails());
    Console.WriteLine(movies?.Count);
}