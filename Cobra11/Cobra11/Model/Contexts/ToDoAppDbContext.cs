using Microsoft.EntityFrameworkCore;

namespace Cobra11.Model.Contexts
{
    public class ToDoAppDbContext : DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ToDoItem>()
                .ToTable("ToDoItems")
                .HasKey(p => p.Id);
        }
    }
}
