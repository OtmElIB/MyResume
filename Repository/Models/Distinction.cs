using Repository.Models.Core;

namespace Repository.Models
{
    /// <summary>
    /// Distinction Entity
    /// </summary>
    public class Distinction : Entity<long>
    {
        public string Title { get; set; }

        public long? PersonID { get; set; }

        public Person Person { get; set; }
    }
}
