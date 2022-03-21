using System.ComponentModel.DataAnnotations;

namespace REST_API.Data.DTOs;
public class ReadMovieDTO
{
    public string Title { get; set; }

    public string Director { get; set; }

    public string Genre { get; set; }

    public int MovieLengthInMinutes { get; set; }

    public int AgeRating { get; set; }
}
