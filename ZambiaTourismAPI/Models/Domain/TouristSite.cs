using System.Globalization;

namespace ZambiaTourismAPI.Models.Domain
{
    public class TouristSite
    {
        public Guid Id { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public double? SizeInKmSq { get; set; }
        public string? SiteImage { get; set; }

        // Foreign Keys
        public Guid RegionId { get; set; }
        public Guid SiteRatingId  { get; set; }

        // Navigation Properties : defines the relationship between the entities
        public Region Region { get; set; }
        public Rating Rating { get; set; }
    }
}
