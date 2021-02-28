using Repository.Repositories.Core;

namespace Repository.Models
{
    public class Person : Entity<long>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
        
    }
}
