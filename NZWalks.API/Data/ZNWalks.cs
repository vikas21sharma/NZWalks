using Microsoft.EntityFrameworkCore;
using NZWalks.API.Model.Domain;

namespace NZWalks.API.Data
{
    public class ZNWalks : DbContext
    {
        //Parameter consturctor for if we use futhur connection string in program.cs. udem v  19
        public ZNWalks(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Walks> Walk { get; set; }
    }
}
