using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

[ApiController]

[Route("[controller]")]
public class MovieController
{

    private static List<Movie> movies = new List<Movie>();

    [HttpPost] // POST method
    public void AddMovie([FromBody] Movie movie)
    {
        movies.Add(movie);
    }

}