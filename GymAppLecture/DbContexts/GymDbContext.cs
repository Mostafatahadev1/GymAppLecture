using GymAppLecture.Models;
using Microsoft.EntityFrameworkCore;
namespace GymAppLecture.DbContexts
{
    public class GymDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymManagement;" +
                    "Trusted_Connection=True;TrustServerCertificate=True");
                
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new Configurations.PlanConfiguration());

        }
        public DbSet<Models.Plan> Plans { get; set; } = null!;
    }
}
