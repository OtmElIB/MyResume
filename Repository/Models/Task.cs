using Repository.Models.Core;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public class Task : Entity<long>
    {
        public string Title { get; set; }
        public long? ProfessionalExperienceID { get; set; }
        [JsonIgnore]
        public ProfessionalExperience ProfessionalExperience { get; set; }
    }
}
