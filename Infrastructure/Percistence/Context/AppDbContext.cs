using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Infrastructure.Percistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Class> Classes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;port=5432;user id=postgres;password=1234;database=PortalCursos;pooling=true";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");

            modelBuilder.Entity<Class>().ToTable("Classes");
            modelBuilder.Entity<Class>().HasOne(e => e.Module).WithMany(e => e.ClassList).HasForeignKey(e => e.ModuleId);

            modelBuilder.Entity<Module>().ToTable("Modules");
            modelBuilder.Entity<Module>().HasOne(e => e.Course).WithMany(e => e.ModuleList).HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Course>().HasOne(e => e.Category).WithMany(e => e.CourseList).HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Category>().ToTable("Categories");
        }
    }
}
