using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace REST_API.Models;

public class Manager
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string ManagerName { get; set; }

    [JsonIgnore]
    public virtual List<MovieTheater> MovieTheaters { get; set; }
}