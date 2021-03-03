using Repository.Models.Core;
using System.Collections.ObjectModel;

namespace Repository.Models
{
    /// <summary>
    /// PEType Entity
    /// </summary>
    public class PEType : Entity<long>
    {
        public string Title { get; set; }

        public Collection<ProfessionalExperience> ProfessionalExperiences { get; set; }
    }
}
