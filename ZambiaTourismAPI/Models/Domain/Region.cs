namespace ZambiaTourismAPI.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionDescription { get; set; }
        public string? RegionImage { get; set; }
        public string? RegionURL { get; set; }
    }
}
