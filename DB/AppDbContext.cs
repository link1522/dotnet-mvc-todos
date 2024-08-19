using Microsoft.EntityFrameworkCore;
using dotnet_mvc_todos.Models;

namespace dotnet_mvc_todos.DB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }
}