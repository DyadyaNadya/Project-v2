using Microsoft.EntityFrameworkCore;
using Project_v2.Models;
using System.Security.Cryptography.X509Certificates;
namespace Project_v2.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Players> Players => Set<Players>();
        public DbSet<Teams> Teams => Set<Teams>();
        public DbSet<Achievements> Achievements => Set<Achievements>();

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.HasDefaultSchema("nba");
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=4057");
        }
    }
}
