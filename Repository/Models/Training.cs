using Repository.Models.Core;

namespace Repository.Models
{
    public class Training : Entity<long>
    {
        public string SchoolName { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}
