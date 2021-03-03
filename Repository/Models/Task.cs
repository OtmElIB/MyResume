using Repository.Models.Core;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    /// <summary>
    /// Task Entity
    /// </summary>
    public class Task : Entity<long>
    {
        public string Title { get; set; }

        public long? ProfessionalExperienceID { get; set; }

        public ProfessionalExperience ProfessionalExperience { get; set; }
    }
}
