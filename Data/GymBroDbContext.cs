using GymBro_Backend_API.Models;
using Microsoft.EntityFrameworkCore;

namespace GymBro_Backend_API.Data
{
    public class GymBroDbContext(DbContextOptions<GymBroDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            
        }

    }
}
