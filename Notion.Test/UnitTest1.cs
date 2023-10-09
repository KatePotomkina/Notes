using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Moq;
using Notion;
using Notion.Data;
using Notion.Models;
using Notion.Service;

namespace Notion.Test;

public class UnitTest1
{
    [Fact]
    public async Task CreateNote_ShouldCreateNoteAndNavigateToRoot()
    {
        // Arrange
        var dbContextOptions = new DbContextOptionsBuilder<ApiDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Use an in-memory database for testing
            .Options;

        using var context = new ApiDbContext(dbContextOptions); // Replace with the actual context
        var navigationManager = new Mock<NavigationManager>().Object; // Use a mocking framework to create a mock NavigationManager
        var noteService = new NotionService(context, navigationManager);
        var note = new Notes
        {
            // Set properties of the note as needed for testing
            Title = "Test Note",
            Content = "This is a test note.",
            Created_At = DateTime.UtcNow // Set the created date as needed
        };

        // Act
        await noteService.CreateNote(note);

        // Assert
        // Verify that the note was added to the database
        var createdNote = context.Notes.FirstOrDefault(n => n.Title == "Test Note");
        Assert.NotNull(createdNote);

        // Verify that the navigation manager was called to navigate to the root
        navigationManager.Verify(nav => nav.NavigateTo("/"), Times.Once);
    }
}