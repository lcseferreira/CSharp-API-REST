using System.Text.Json.Serialization;
using REST_API.Models;

namespace REST_API.Data.DTOs;
public class ReadMovieTheaterDTO
{
    public string MovieTheaterName { get; set; }
    public object Address { get; set; }
    public object Manager { get; set; }
}
