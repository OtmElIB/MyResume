using Repository.Models.Core;

namespace Repository.Models
{
    public class Task : Entity<long>
    {
        public string Title { get; set; }
        public long? ProfessionalExperienceID { get; set; }
        public ProfessionalExperience ProfessionalExperience { get; set; }
    }
}
