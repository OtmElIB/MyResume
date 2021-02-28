using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class SkillRepository : ApplicationRepositoty<Skill, long>, ISkillRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="SkillRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public SkillRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
