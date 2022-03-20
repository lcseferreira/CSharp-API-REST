using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using REST_API.Data;
using REST_API.Data.DTOs;
using REST_API.Models;

namespace REST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieTheaterController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public MovieTheaterController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetMovieTheaters()
    {
        return Ok(_context.MovieTheaters.ToList());

    }

    [HttpGet("{id}")]
    public IActionResult GetMovieTheaterById(int id)
    {
        // MovieTheater movieTheater = _context.MovieTheaters.FirstOrDefault(movieTheater => movieTheater.Id == id);
        var movieTheater = _context.MovieTheaters.Find(id);
        if (movieTheater == null) return NotFound();
        // ReadMovieTheaterDTO movieTheaterDTO = _mapper.Map<ReadMovieTheaterDTO>(movieTheater);
        var movieTheaterDTO = _mapper.Map<ReadMovieTheaterDTO>(movieTheater);

        return Ok(movieTheaterDTO);
    }

    [HttpPost]
    public IActionResult AddMovieTheater([FromBody] CreateMovieTheaterDTO movieTheaterDTO)
    {
        MovieTheater movieTheater = _mapper.Map<MovieTheater>(movieTheaterDTO);

        _context.MovieTheaters.Add(movieTheater);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetMovieTheaterById), new { Id = movieTheater.Id }, movieTheater);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMovieTheater([FromBody] UpdateMovieDTO movieTheaterDTO, int id)
    {
        MovieTheater movieTheater = _context.MovieTheaters.Find(id);

        if (movieTheater == null) return NotFound();

        _mapper.Map(movieTheaterDTO, movieTheater);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveMovieTheater(int id)
    {
        MovieTheater movieTheater = _context.MovieTheaters.Find(id);

        if (movieTheater == null) return NotFound();

        _context.MovieTheaters.Remove(movieTheater);
        _context.SaveChanges();

        return NoContent();
    }

}