using Microsoft.EntityFrameworkCore;
using SocialAssistanceFund.Models;
using SocialAssistanceFund.Services;

public class ApplicantService : IApplicantService
{
    private readonly ApplicationDbContext _context;

    public ApplicantService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Applicant>> GetAllApplicantsAsync()
    {
        return await _context.Applicants
            .Include(a => a.Village)
            .Include(a => a.Sex)
            .Include(a => a.MaritalStatus)
            .Include(a => a.Programs).ThenInclude(ap => ap.Program)
            .ToListAsync();
    }

    public async Task<Applicant> GetApplicantByIdAsync(int id)
    {
        return await _context.Applicants
            .Include(a => a.Village)
            .Include(a => a.Sex)
            .Include(a => a.MaritalStatus)
            .Include(a => a.Programs).ThenInclude(ap => ap.Program)
            .FirstOrDefaultAsync(a => a.ApplicantId == id);
    }

    public async Task AddApplicantAsync(Applicant applicant)
    {
        try
        {
           // applicant.IdNumber = "1";
            _context.Applicants.Add(applicant);
            await _context.SaveChangesAsync();
        }
        catch(Exception e)
        {
            throw e;
        }

    }

    public async Task UpdateApplicantAsync(Applicant applicant)
    {
        _context.Applicants.Update(applicant);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteApplicantAsync(int id)
    {
        var applicant = await _context.Applicants.FindAsync(id);
        if (applicant != null)
        {
            _context.Applicants.Remove(applicant);
            await _context.SaveChangesAsync();
        }
    }
}