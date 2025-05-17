using GymBro_Backend_API.Models;
using Microsoft.EntityFrameworkCore;

namespace GymBro_Backend_API.Data
{
    public class GymBroDbContext(DbContextOptions<GymBroDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

    }
}
