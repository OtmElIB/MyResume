﻿using System;

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
    }
}
