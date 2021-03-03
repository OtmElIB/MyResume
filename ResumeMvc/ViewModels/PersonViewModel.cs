﻿namespace ResumeMvc.ViewModels
{
    /// <summary>
    /// PersonViewModel Objet Utilisé dans les Views
    /// </summary>
    public class PersonViewModel
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
