using REST_API.Models;

namespace REST_API.Data;

public class ReadSectionDTO
{
    public MovieTheater MovieTheater { get; set; }
    public Movie Movie { get; set; }
    public DateTime EndSection { get; set; }
    public DateTime StartSection { get; set; }
}