using Repository.Repositories.Core;

namespace Repository.Models
{
    public class Task : Entity<long>
    {
        public string Title { get; set; }
    }
}
