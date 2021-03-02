using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class LanguageRepository : ApplicationRepositoty<Language, long>, ILanguageRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="LanguageRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public LanguageRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
