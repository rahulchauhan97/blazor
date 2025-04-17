using SocialAssistanceFund.Models;

public class ApplicantProgram { public int ApplicantProgramId { get; set; } public int ApplicantId { get; set; } public int ProgramId { get; set; } public Applicant Applicant { get; set; } public SocialProgram Program { get; set; } }
