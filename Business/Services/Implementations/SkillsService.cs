using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class SkillsService : EntityService<Skill, long>, ISkillsService
    {
        public SkillsService(ISkillRepository repository)
            : base(repository)
        {
        }
    }
}
