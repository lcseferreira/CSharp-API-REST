using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace REST_API.Models;

public class MovieTheater
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = ("The Name field is required."))]
    public string MovieTheaterName { get; set; }

    public virtual Address Address { get; set; }

    [JsonIgnore]
    public int AddressId { get; set; }

    public virtual Manager Manager { get; set; }

    [JsonIgnore]
    public int ManagerId { get; set; }

    [JsonIgnore]
    public virtual List<Section> Sections { get; set; }
}