using Repository.Models.Core;
using System.Collections.ObjectModel;

namespace Repository.Models
{
    /// <summary>
    /// Person Entity
    /// </summary>
    public class Person : Entity<long>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public Collection<Link> Links { get; set; }

        public Collection<Skill> Skills { get; set; }

        public Collection<Language> Languages { get; set; }

        public Collection<Training> Trainings { get; set; }

        public Collection<Distinction> Distinctions { get; set; }

        public Collection<ProfessionalExperience> ProfessionalExperiences { get; set; }

    }
}
