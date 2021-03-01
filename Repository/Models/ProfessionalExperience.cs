using Repository.Models.Core;
using System;
using System.Collections.ObjectModel;

namespace Repository.Models
{
    public class ProfessionalExperience : Entity<long>
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long? PersonID { get; set; }
        public Person Person { get; set; }
        public Collection<Technology> Technologies { get; set; }
        public Collection<Task> Tasks { get; set; }
        public long? TypeID { get; set; }
        public PEType Type { get; set; }
    }
}
