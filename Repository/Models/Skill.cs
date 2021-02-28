using Repository.Repositories.Core;

namespace Repository.Models
{
    public class Skill : Entity<long>
    {
        public string Title { get; set; }

        public int Score { get; set; }
    }
}
