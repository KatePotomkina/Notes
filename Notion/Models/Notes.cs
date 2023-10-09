using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notion.Models;

public class Notes
{
    private int id;
    private string? content;

    private string? title;
   // private DateTime created_at;

    [Key]
    [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get=>id; set=>id=value; }

    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Content
    {
        get => content;
        set => content = value;
    }

    public DateTime Created_At { get; set; } = DateTime.UtcNow; // Initialize to UtcNow


    // Constructor to set Created_At to the current date and time
 
}