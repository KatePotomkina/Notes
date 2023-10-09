/*using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notion.Data;
using Notion.Models;

namespace Notion.Controllers;
[ApiController]
[Route("api/[controller]")]
public class NoteController : ControllerBase
{
  private readonly ApiDbContext _context;

  public NoteController(ApiDbContext contex)
  {
    _context = _context;
  }

  [HttpGet]
  public async Task<ActionResult<List<Notes>>>GetAll()
  {
    var notes = _context.Notes.ToListAsync();
    return Ok(notes);
  }
  [HttpGet("{id}")]
  public async Task<ActionResult<List<Notes>>>GetDetail(int id)
  {
    try
    {
      var note = _context.Notes.FirstOrDefaultAsync(x=>x.Id==id);
      if (note == null)
      {
        return NotFound();
      }
      return Ok(note);
      
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }
   
  }

  [HttpPost]
  public async Task<IActionResult> CreateNote(Notes note)
  {
    _context.Notes.Add(note);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetDetail), note, note.Id);
  }

  /*[HttpPut("{id}")]
  public async Task<IActionResult> UpdateNote(Notes noteNew, int id)
  {
   
  }#1#
}*/

