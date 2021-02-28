using Repository.Models.Core;

namespace Repository.Models
{
    public class Task : Entity<long>
    {
        public string Title { get; set; }
    }
}
