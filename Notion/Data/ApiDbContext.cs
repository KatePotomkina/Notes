using Microsoft.EntityFrameworkCore;
using Notion.Models;

namespace Notion.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
    {
    }

    public DbSet<Notes> Notes => Set<Notes>();
}