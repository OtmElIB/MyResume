using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class DistinctionsService : EntityService<Distinction, long>, IDistinctionsService
    {
        public DistinctionsService(IDistinctionRepository repository)
            : base(repository)
        {
        }
    }
}
