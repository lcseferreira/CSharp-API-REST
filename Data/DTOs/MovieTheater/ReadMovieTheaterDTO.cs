using REST_API.Models;

namespace REST_API.Data.DTOs;
public class ReadMovieTheaterDTO
{
    public string MovieTheaterName { get; set; }
    public Address Address { get; set; }
    public Manager Manager { get; set; }
}
