using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class TechnologiesRepository : ApplicationRepositoty<Technology, long>, ITechnologiesRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="TechnologiesRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public TechnologiesRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
