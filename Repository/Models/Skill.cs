using Repository.Models.Core;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public class Skill : Entity<long>
    {
        public string Title { get; set; }

        public int Score { get; set; }

        public long? PersonID { get; set; }

        [JsonIgnore]
        public Person Person { get; set; }
    }
}
