using System.ComponentModel.DataAnnotations;

namespace REST_API.Models;

public class Manager
{
    [Key]
    [Required]
    public int Id { get; set; }

    public string ManagerName { get; set; }
    
}