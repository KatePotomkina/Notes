using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Notion.Data;
using Notion.Models;

namespace Notion.Service;

public class NotionService : INotionService
{
    private readonly ApiDbContext _context;
    private readonly NavigationManager _navigationManager;

    public NotionService(ApiDbContext context, NavigationManager navigationManager)
    {
        _context = context;
        _navigationManager = navigationManager;
    }

    public async Task<int> GetCountNotes()
    {
         return   _context.Notes.Count();
    }

    public List<Notes> NotesList { get; set; } = new();

    public async Task GetNotes()
    {
        NotesList = await _context.Notes.ToListAsync();
    }

    public async Task CreateNote(Notes note)
    {
        _context.Notes.Add(note);
        await _context.SaveChangesAsync();
        _navigationManager.NavigateTo("/");
    }

    public async Task GetOneNote(int id)
    {
        if (_context.Notes != null)
        {
            var note = await _context.Notes.FirstOrDefaultAsync(x => x.Id == id);
            if (note == null) throw new Exception("No notes");
        }
    }

    public IEnumerable<Notes> Filter(string filter)
    {
        return _context.Notes.Where(note => note.Title.Contains(filter) || note.Content.Contains(filter));
    }
    public async Task EditNote(Notes noteNew, int id)
    {
        var noteOld = await _context.Notes.FirstOrDefaultAsync(x => x.Id == id);
        if (noteOld == null) throw new Exception("Not Found");

        noteOld.Content = noteNew.Content;
        noteOld.Title = noteNew.Title;
        await _context.SaveChangesAsync();
        _navigationManager.NavigateTo("/");
    }
}