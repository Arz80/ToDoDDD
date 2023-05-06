using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Datas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ToDoTask> ToDoTasks { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Status> Statuses { get; set; }
}
