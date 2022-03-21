
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace REST_API.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "The Title field is required.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The Director field is required.")]
    public string Director { get; set; }

    [MaxLength(60, ErrorMessage = "Max length is 60.")]
    public string Genre { get; set; }

    [Range(1, 600, ErrorMessage = "The length of the movie must be between 1 and 600 minutes.")]
    public int MovieLengthInMinutes { get; set; }

    public int AgeRating { get; set; }

    [JsonIgnore]
    public virtual List<Section> Sections { get; set; }
}