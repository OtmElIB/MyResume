using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class DistinctionRepository : ApplicationRepositoty<Distinction, long>, IDistinctionRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="DistinctionRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public DistinctionRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
