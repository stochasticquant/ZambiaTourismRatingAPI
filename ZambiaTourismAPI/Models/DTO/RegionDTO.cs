namespace ZambiaTourismAPI.Models.DTO
{
    // A DTO can be used to transfer data between the layers of the application
    // It can be all or a subset of the data in the domain model
    // For security reasons we may not want to expose all the data in the domain model or based on business requirements
    public class RegionDTO
    {
        public Guid Id { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionDescription { get; set; }
        public string? RegionImage { get; set; }
        public string? RegionURL { get; set; }

    }
}
