using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class LinkRepository : ApplicationRepositoty<Link, long>, ILinkRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="LinkRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public LinkRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
