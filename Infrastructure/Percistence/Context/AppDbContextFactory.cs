using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Percistence.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;port=5432;user id=postgres;password=1234;database=PortalCursos;pooling=true";

            var builder = new DbContextOptionsBuilder<AppDbContext>();

            builder.UseNpgsql(connectionString);

            return new AppDbContext(builder.Options);
        }
    }
}