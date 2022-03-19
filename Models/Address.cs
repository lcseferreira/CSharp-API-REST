using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace REST_API.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Street { get; set; }

    [Required]
    public string District { get; set; }

    [Required]
    public int Number { get; set; }

    [JsonIgnore]
    public virtual MovieTheater MovieTheater { get; set; }
}