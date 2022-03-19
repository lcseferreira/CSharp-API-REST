using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

public class Movie
{
    [Required(ErrorMessage = "The Title field is required.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The Director field is required.")] 
    public string Director { get; set; }
    public string Genre { get; set; }

    [Range(1, 600, ErrorMessage = "The lentgth of movie must be between 1 and 600 minutes.")]
    public int MovieLengthInMinutes { get; set; }
}