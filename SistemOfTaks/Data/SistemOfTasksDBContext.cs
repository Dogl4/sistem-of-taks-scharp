using Microsoft.EntityFrameworkCore;
using SistemOfTaks.Models;

namespace SistemOfTaks.Data
{
    public class SistemOfTasksDBContext : DbContext
    {
        public SistemOfTasksDBContext(DbContextOptions<SistemOfTasksDBContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}