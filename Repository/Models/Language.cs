using Repository.Models.Core;

namespace Repository.Models
{
    public class Language : Entity<long>
    {
        public string Title { get; set; }

        public int Score { get; set; }
    }
}
