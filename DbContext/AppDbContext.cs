using Microsoft.EntityFrameworkCore;
using LocationTrackerAPI.Models;

namespace LocationTrackerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Location> Locations => Set<Location>();
    }
}
