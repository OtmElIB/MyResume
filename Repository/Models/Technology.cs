using Repository.Models.Core;

namespace Repository.Models
{
    public class Technology : Entity<long>
    {
        public string Title { get; set; }
        public long? ProfessionalExperienceID { get; set; }
        public ProfessionalExperience ProfessionalExperience { get; set; }
    }
}
