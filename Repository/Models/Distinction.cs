using Repository.Models.Core;

namespace Repository.Models
{
    public class Distinction : Entity<long>
    {
        public string Title { get; set; }
    }
}
