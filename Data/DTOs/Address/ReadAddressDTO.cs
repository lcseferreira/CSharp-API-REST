using System.ComponentModel.DataAnnotations;

namespace REST_API.Data;

public class ReadAddressDTO
{
    [Required]
    public string Street { get; set; }

    [Required]
    public string District { get; set; }

    [Required]
    public int Number { get; set; }
}