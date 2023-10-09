using Notion.Models;

namespace Notion.Service;

public interface INotionService
{
    Task<int>GetCountNotes();
    List<Notes> NotesList { get; set; }
    IEnumerable<Notes> Filter(string filter);
    Task GetNotes();
    Task CreateNote(Notes note);
    Task GetOneNote(int id);
    Task EditNote(Notes editedNote, int id);
}