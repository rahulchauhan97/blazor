using SocialAssistanceFund.Models;

namespace SocialAssistanceFund.Services
{
    public interface IApplicantService
    {
        Task<IEnumerable<Applicant>> GetAllApplicantsAsync();
        Task<Applicant> GetApplicantByIdAsync(int id);
        Task AddApplicantAsync(Applicant applicant);
        Task UpdateApplicantAsync(Applicant applicant);
        Task DeleteApplicantAsync(int id);
    }
}
