using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class TrainingRepository : ApplicationRepositoty<Training, long>, ITrainingRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="TrainingRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public TrainingRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
