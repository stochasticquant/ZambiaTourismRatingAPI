namespace ZambiaTourismAPI.Models.DTO
{
    // This DTO should only have properties allowed to be updated as per business requirements
    public class UpdateRegionRequestDTO
    {
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionDescription { get; set; }
        public string? RegionImage { get; set; }
        public string? RegionURL { get; set; }
    }
}
