using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class PETypeRepository : ApplicationRepositoty<PEType, long>, IPETypeRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="PETypeRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public PETypeRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
