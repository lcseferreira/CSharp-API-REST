using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    // Injection
    public AddressController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /* HTTP methods */
    [HttpGet]
    public IActionResult GetAddresses()
    {
        return Ok(_context.Addresses);
    }

    [HttpGet("{id}")]
    public IActionResult GetAddressById(int id)
    {
        Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);

        if (address == null) return NotFound();

        ReadAddressDTO addressDTO = _mapper.Map<ReadAddressDTO>(address);

        return Ok(addressDTO);
    }

    [HttpPost]
    public IActionResult AddAddress([FromBody] CreateAddressDTO addressDTO)
    {
        Address address = _mapper.Map<Address>(addressDTO);

        _context.Add(address);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetAddressById), new { Id = address.Id }, address);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAddress([FromBody] UpdateAddressDTO addressDTO, int id)
    {
        Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);

        if (address == null) return NotFound();

        _mapper.Map(addressDTO, address);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveAddress(int id)
    {
        Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);

        if (address == null) return NotFound();

        _context.Remove(address);
        _context.SaveChanges();

        return NoContent();
    }



}