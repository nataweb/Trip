using Microsoft.EntityFrameworkCore;
using Trip.API.Models.Domain;

namespace Trip.API.Data
{
    public class TripDbContext:DbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options):
            base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }


    }
}
