using Microsoft.EntityFrameworkCore;
using ZambiaTourismAPI.Models.Domain;

namespace ZambiaTourismAPI.Data
{
    public class TouristSitesDBContext : DbContext
    {
        public TouristSitesDBContext(DbContextOptions dnContextOptions): base(dnContextOptions)
        {
                
        }

        // Represents the TouristSites tables in the database
        public DbSet<Rating> MyProperty { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<TouristSite> TouristSites { get; set; }
    }
}
