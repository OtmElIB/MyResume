using Repository.Repositories.Core;

namespace Repository.Models
{
    public class Distinction : Entity<long>
    {
        public string Title { get; set; }
    }
}
