using REST_API.Models;

namespace REST_API.Data;

public class ReadManagerDTO
{
    public string ManagerName { get; set; }
    public List<MovieTheater> MovieTheaters { get; set; }
}