using Repository.Repositories.Core;
using System;

namespace Repository.Models
{
    public class ProfessionalExperience : Entity<long>
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
