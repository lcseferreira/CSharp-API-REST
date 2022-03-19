using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{

    private static List<Movie> movies = new List<Movie>();

    [HttpGet]
    public IActionResult GetMovies()
    {
        return Ok(movies);
    }

    [HttpGet("{id}")]
    public IActionResult GetMovieById(int id)
    {
        Movie? movie = movies.FirstOrDefault(movie => movie.Id == id);

        if (movie != null) return Ok(movie);

        return NotFound();
    }

    [HttpPost] // POST method
    public IActionResult AddMovie([FromBody] Movie movie)
    {
        movies.Add(movie);
        return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
    }
}