using Repository.Models.Core;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public class Training : Entity<long>
    {
        public string SchoolName { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public long? PersonID { get; set; }

        [JsonIgnore]
        public Person Person { get; set; }
    }
}
