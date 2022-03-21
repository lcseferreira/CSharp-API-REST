using System.ComponentModel.DataAnnotations;

namespace REST_API.Models;

public class Section
{
    [Key]
    [Required]
    public int Id { get; set; }

    public virtual MovieTheater MovieTheater { get; set; }
    public virtual Movie Movie { get; set; }
    public int MovieTheaterId { get; set; }
    public int MovieId { get; set; }
    public DateTime EndSection { get; set; }
}