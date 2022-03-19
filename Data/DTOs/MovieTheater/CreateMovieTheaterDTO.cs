using System.ComponentModel.DataAnnotations;

namespace REST_API.Data.DTOs;
public class CreateMovieTheaterDTO
{
    [Required(ErrorMessage = "The Name field is required.")]
    public string MovieTheaterName { get; set; }

    public int AddressId { get; set; }
}
