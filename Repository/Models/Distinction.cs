using Repository.Models.Core;

namespace Repository.Models
{
    public class Distinction : Entity<long>
    {
        public string Title { get; set; }

        public long? PersonID { get; set; }
        public Person Person { get; set; }
    }
}
