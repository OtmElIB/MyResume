using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;
using System.Linq;

namespace Repository.Repositories.Implementations
{
    public class ProfessionalExperienceRepository : ApplicationRepositoty<ProfessionalExperience, long>, IProfessionalExperienceRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="ProfessionalExperienceRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public ProfessionalExperienceRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        protected override IQueryable<ProfessionalExperience> Include()
        {
            return base.Include()
                .Include(x => x.Technologies)
                .Include(x => x.Tasks)
                .Include(x => x.Type);
        }
    }
}
