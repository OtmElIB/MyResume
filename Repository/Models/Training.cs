using Repository.Models.Core;

namespace Repository.Models
{
    /// <summary>
    /// Training Entity
    /// </summary>
    public class Training : Entity<long>
    {
        public string SchoolName { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public long? PersonID { get; set; }

        public Person Person { get; set; }
    }
}
