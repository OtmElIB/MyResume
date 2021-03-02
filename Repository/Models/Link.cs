using Repository.Models.Core;
using System.Text.Json.Serialization;

namespace Repository.Models
{
    public class Link : Entity<long>
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public long? PersonID { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
    }
}
