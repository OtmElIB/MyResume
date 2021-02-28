using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

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
    }
}
