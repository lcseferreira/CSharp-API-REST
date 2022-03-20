using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Controllers;

[ApiController]
[Route("{id}")]
public class ManagerController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public ManagerController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult GetManagerById(int id)
    {
        Manager manager = _context.Managers.FirstOrDefault(manager => manager.Id == id);

        if (manager == null) return NotFound();

        ReadManagerDTO managerDTO = _mapper.Map<ReadManagerDTO>(manager);

        return Ok(managerDTO);
    }

    [HttpPost]
    public IActionResult AddManager([FromBody] CreateManagerDTO managerDTO)
    {
        Manager manager = _mapper.Map<Manager>(managerDTO);

        _context.Managers.Add(manager);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetManagerById), new { Id = manager.Id }, manager);
    }

}