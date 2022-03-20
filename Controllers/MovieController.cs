using Microsoft.AspNetCore.Mvc;
using REST_API.Models;
using REST_API.Data.DTOs;
using AutoMapper;
using REST_API.Data;

namespace REST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private AppDbContext _context;
    private IMapper _mapper;

    public MovieController(REST_API.Data.AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpGet] // GET movies
    public IActionResult GetMovies()
    {
        return Ok(_context.Movies.ToList());
    }

    [HttpGet("{id}")] // GET movie by ID
    public IActionResult GetMovieById(int id)
    {
        Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

        if (movie != null)
        {
            ReadMovieDTO movieDTO = _mapper.Map<ReadMovieDTO>(movie);
            return Ok(movieDTO);
        }

        return NotFound();
    }

    [HttpPost] // POST movie
    public IActionResult AddMovie([FromBody] CreateMovieDTO movieDTO)
    {
        Movie movie = _mapper.Map<Movie>(movieDTO);

        _context.Movies.Add(movie);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
    }

    [HttpPut("{id}")] // UPDATE movie
    public IActionResult UpdateMovie([FromBody] UpdateMovieDTO movieDTO, int id)
    {
        Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

        if (movie == null) return NotFound();

        _mapper.Map(movieDTO, movie);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")] // DELETE movie
    public IActionResult RemoveMovie(int id)
    {
        Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

        if (movie == null) return NotFound();

        _context.Movies.Remove(movie);
        _context.SaveChanges();

        return NoContent();
    }
}