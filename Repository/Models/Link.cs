using Repository.Models.Core;

namespace Repository.Models
{
    public class Link : Entity<long>
    {
        public string Url { get; set; }
    }
}
