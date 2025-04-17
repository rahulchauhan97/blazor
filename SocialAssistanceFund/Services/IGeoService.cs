using SocialAssistanceFund.Models;

public interface IGeoService
{
    Task<List<County>> GetCountiesAsync();
    Task<List<SubCounty>> GetSubCountiesAsync(int countyId);
    Task<List<Location>> GetLocationsAsync(int subCountyId);
    Task<List<SubLocation>> GetSubLocationsAsync(int locationId);
    Task<List<Village>> GetVillagesAsync(int subLocationId);
    Task<List<Sex>> GetSexesAsync();
    Task<List<MaritalStatus>> GetMaritalStatusesAsync();
    Task<IEnumerable<SubCounty>> GetSubCountiesByCountyIdAsync(int countyId);
    Task<IEnumerable<Location>> GetLocationsBySubCountyIdAsync(int subCountyId);
    Task<IEnumerable<SubLocation>> GetSubLocationsByLocationIdAsync(int locationId);
    Task<IEnumerable<Village>> GetVillagesBySubLocationIdAsync(int subLocationId);
}
