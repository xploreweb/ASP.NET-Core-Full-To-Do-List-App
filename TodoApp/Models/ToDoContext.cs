using Microsoft.EntityFrameworkCore;

namespace TodoApp.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "töö", Name="Töö"},
                new Category { CategoryID = "kodu", Name="Kodu" },
                new Category { CategoryID = "trenn", Name="Treening" },
                new Category { CategoryID = "pood", Name="Ostud" },
                new Category { CategoryID = "tel", Name="Kontakt" }
            );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusID = "teha", Name="Teha" },
                new Status { StatusID = "tehtud", Name="Tehtud" }
            );
        }
    }
}
