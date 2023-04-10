using Microsoft.EntityFrameworkCore;
using TasksProject.Data.Data.Models;

namespace TasksProject.Data.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }

        public TasksContext(DbContextOptions<TasksContext> options) : base(options) { }
    }
}
