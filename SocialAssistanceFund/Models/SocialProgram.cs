using System.ComponentModel.DataAnnotations;

namespace SocialAssistanceFund.Models
{
    public class SocialProgram {
        [Key]
        public int ProgramId { get; set; } 
        public string ProgramName { get; set; } 
    }
}
