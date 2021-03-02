using Business.Core;
using Business.Services.Interfaces;
using Repository.Models;
using Repository.Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class TrainingsService : EntityService<Training, long>, ITrainingsService
    {
        public TrainingsService(ITrainingRepository repository)
            : base(repository)
        {
        }
    }
}
