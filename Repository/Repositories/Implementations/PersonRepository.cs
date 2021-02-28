using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class PersonRepository : ApplicationRepositoty<Person, long>, IPersonRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="PersonRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public PersonRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
