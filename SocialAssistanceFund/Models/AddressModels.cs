namespace SocialAssistanceFund.Models
{
    public class County { public int CountyId { get; set; } public string CountyCode { get; set; } public string CountyName { get; set; } }
    public class SubCounty { public int SubCountyId { get; set; } public string SubCountyCode { get; set; } public string SubCountyName { get; set; } public int CountyId { get; set; } public County County { get; set; } }
    public class Location { public int LocationId { get; set; } public string LocationCode { get; set; } public string LocationName { get; set; } public int SubCountyId { get; set; } public SubCounty SubCounty { get; set; } }
    public class SubLocation { public int SubLocationId { get; set; } public string SubLocationCode { get; set; } public string SubLocationName { get; set; } public int LocationId { get; set; } public Location Location { get; set; } }
    public class Village { public int VillageId { get; set; } public string VillageCode { get; set; } public string VillageName { get; set; } public int SubLocationId { get; set; } public SubLocation SubLocation { get; set; } }


}
