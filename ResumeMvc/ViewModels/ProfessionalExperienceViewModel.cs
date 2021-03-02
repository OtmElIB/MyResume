using System;
using System.Collections.Generic;

namespace ResumeMvc.ViewModels
{
    public class ProfessionalExperienceViewModel
    {
        public long ID { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long? TypeID { get; set; }
        public PETypeViewModel Type { get; set; }
        public List<TaskViewModel> Tasks { get; set; }

        public List<TechnologyViewModel> Technologies { get; set; }
    }
}
