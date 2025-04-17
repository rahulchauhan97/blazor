using Microsoft.EntityFrameworkCore;
using SocialAssistanceFund.Models;

public class GeoService : IGeoService
{
    private readonly ApplicationDbContext _context;

    public GeoService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<County>> GetCountiesAsync()
    {
        return await _context.Counties.OrderBy(c => c.CountyName).ToListAsync();
    }

    public async Task<List<SubCounty>> GetSubCountiesAsync(int countyId)
    {
        return await _context.SubCounties
            .Where(sc => sc.CountyId == countyId)
            .OrderBy(sc => sc.SubCountyName)
            .ToListAsync();
    }

    public async Task<List<Location>> GetLocationsAsync(int subCountyId)
    {
        return await _context.Locations
            .Where(l => l.SubCountyId == subCountyId)
            .OrderBy(l => l.LocationName)
            .ToListAsync();
    }

    public async Task<List<SubLocation>> GetSubLocationsAsync(int locationId)
    {
        return await _context.SubLocations
            .Where(sl => sl.LocationId == locationId)
            .OrderBy(sl => sl.SubLocationName)
            .ToListAsync();
    }

    public async Task<List<Village>> GetVillagesAsync(int subLocationId)
    {
        return await _context.Villages
            .Where(v => v.SubLocationId == subLocationId)
            .OrderBy(v => v.VillageName)
            .ToListAsync();
    }

    public async Task<List<Sex>> GetSexesAsync()
    {
        return await _context.Sexes.OrderBy(s => s.Description).ToListAsync();
    }

    public async Task<List<MaritalStatus>> GetMaritalStatusesAsync()
    {
        return await _context.MaritalStatuses.OrderBy(ms => ms.Description).ToListAsync();
    }

    public async Task<IEnumerable<SubCounty>> GetSubCountiesByCountyIdAsync(int countyId)
    {
        return await _context.SubCounties.Where(sc => sc.CountyId == countyId).ToListAsync();
    }

    public async Task<IEnumerable<Location>> GetLocationsBySubCountyIdAsync(int subCountyId)
    {
        return await _context.Locations.Where(l => l.SubCountyId == subCountyId).ToListAsync();
    }

    public async Task<IEnumerable<SubLocation>> GetSubLocationsByLocationIdAsync(int locationId)
    {
        return await _context.SubLocations.Where(sl => sl.LocationId == locationId).ToListAsync();
    }

    public async Task<IEnumerable<Village>> GetVillagesBySubLocationIdAsync(int subLocationId)
    {
        return await _context.Villages.Where(v => v.SubLocationId == subLocationId).ToListAsync();
    }
}
