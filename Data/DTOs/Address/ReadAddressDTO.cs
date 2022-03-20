using System.ComponentModel.DataAnnotations;

namespace REST_API.Data;

public class ReadAddressDTO
{

    public string Street { get; set; }
    public string District { get; set; }
    public int Number { get; set; }
}