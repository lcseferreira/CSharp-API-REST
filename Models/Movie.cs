
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

public class Movie
{
    [Key()]
    public int Id { get; set; }

    [Required(ErrorMessage = "The Title field is required.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The Director field is required.")]
    public string Director { get; set; }

    [MaxLength(60, ErrorMessage = "Max length is 60.")]
    public string Genre { get; set; }

    [Range(1, 600, ErrorMessage = "The movie's length must be between 1 and 600 minutes.")]
    public int MovieLengthInMinutes { get; set; }
}