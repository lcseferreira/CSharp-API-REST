using System.ComponentModel.DataAnnotations;

namespace REST_API.Data.DTOs;
public class CreateMovieTheaterDTO
{
    public string MovieTheaterName { get; set; }
    public int AddressId { get; set; }
    public int ManagerId { get; set; }
}
