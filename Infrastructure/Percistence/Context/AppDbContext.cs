using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Infrastructure.Percistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // String de conexão ODBC
            string connectionString = "Server=localhost;port=5432;user id=postgres;password=1234;database=PortalCursos;pooling=true";

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
