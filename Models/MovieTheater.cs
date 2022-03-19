using System.ComponentModel.DataAnnotations;

namespace REST_API.Models;

public class MovieTheater
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = ("The name field is required."))]
    public string MovieTheaterName { get; set; }
}