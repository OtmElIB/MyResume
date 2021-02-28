using Repository.Models;
using Repository.Repositories.Core;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories.Implementations
{
    public class TaskRepository : ApplicationRepositoty<Task, long>, ITaskRepository
    {
        /// <summary>
        /// Initialise une nouvelle instance de <see cref="TaskRepository"/>.
        /// </summary>
        /// <param name="dbContext">ApplicationDbContext</param>
        public TaskRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
