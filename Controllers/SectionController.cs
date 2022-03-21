using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class SectionController : ControllerBase
{

    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public SectionController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult GetSectionById(int id)
    {
        Section section = _context.Sections.FirstOrDefault(section => section.Id == id);

        if (section == null) return NotFound();

        ReadSectionDTO sectionDTO = _mapper.Map<ReadSectionDTO>(section);

        return Ok(sectionDTO);
    }

    [HttpPost]
    public IActionResult AddSection([FromBody] CreateSectionDTO sectionDTO)
    {

        Section section = _mapper.Map<Section>(sectionDTO);

        _context.Sections.Add(section);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetSectionById), new { Id = section.Id }, section);
    }

}