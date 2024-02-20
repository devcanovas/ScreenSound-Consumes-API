using ScreenSound_Consumes_API.Filters;
using ScreenSound_Consumes_API.Models;
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

async Task RequestBooksAsync()
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        handleResponseBooks(response);
    }
    catch (Exception e)
    {
        handleException(e);
    }
}

void handleResponseBooks(string response)
{
    List<Book> books = JsonSerializer.Deserialize<List<Book>>(response)!;
    books?.ForEach(book => book.ShowBookDetails());
    Console.WriteLine(books?.Count);
}

void handleResponseCountries(string response)
{
    List<Country> countries = JsonSerializer.Deserialize<List<Country>>(response)!;
    countries?.ForEach(country => country.ShowCountryDetails());
    Console.WriteLine(countries?.Count);
}

static void handleResponseMusic(string response)
{
    List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response)!;
    //LinqFilter.FilterAllGenreInMusics(musics);    
    //LinqOrder.ShowArtistsOrdered(musics);
    //LinqFilter.FilterArtistsByGenre(musics, "rock");
    LinqFilter.FilterMusicsByArtist(musics, "Michel Teló");
}

static void handleResponseMovies(string response)
{
    List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(response)!;
    movies?.ForEach(movie => movie.ShowMovieDetails());
    Console.WriteLine(movies?.Count);
}

void handleException(Exception e)
{
    Console.WriteLine($"Ops! houve um problema inesperado: {e.Message}");
}

await RequestMusicsAsync();