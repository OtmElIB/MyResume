using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class ProfessionalExperiencesService : EntityService<ProfessionalExperience, long>, IProfessionalExperiencesService
    {
        public ProfessionalExperiencesService(IProfessionalExperienceRepository repository)
            : base(repository)
        {
        }
    }
}
