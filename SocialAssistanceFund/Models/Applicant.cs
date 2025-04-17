using System;
using System.Collections.Generic;

namespace SocialAssistanceFund.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int SexId { get; set; }
        public int Age { get; set; }
        public int MaritalStatusId { get; set; }
        public string? IdNumber { get; set; } = string.Empty;
        public int VillageId { get; set; }
        public string? PostalAddress { get; set; } = string.Empty;
        public string? PhysicalAddress { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Signature { get; set; } = string.Empty;
        public DateTime DeclarationDate { get; set; }
        public string? Status { get; set; } = string.Empty;

        public Village Village { get; set; }
        public Sex Sex { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public ICollection<ApplicantProgram> Programs { get; set; }
    }
}
