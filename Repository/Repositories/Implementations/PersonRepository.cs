using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

        protected override IQueryable<Person> Include()
        {
            return base.Include()
                .Include(x => x.Links)
                .Include(x => x.Skills)
                .Include(x => x.Languages)
                .Include(x => x.Trainings)
                .Include(x => x.Distinctions)
                .Include(x => x.ProfessionalExperiences);
        }
    }
}
