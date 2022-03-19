using System.ComponentModel.DataAnnotations;

namespace REST_API.Models;

public class MovieTheater
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = ("The Name field is required."))]
    public string MovieTheaterName { get; set; }

    public virtual Address Address { get; set; }

    public int AddressId { get; set; }
}