using Microsoft.EntityFrameworkCore;
using Repository.Models.Core;

namespace Repository.Repositories.Core
{
    public abstract class ApplicationRepositoty<TEntity, TKey> : EntityRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        /// <summary>
        /// Initailise une nouvelle instance de <see cref="StandardStoreRepository{TEntity, TKey}"/>
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="dateTimeProvider">Fournisseur de date</param>
        protected ApplicationRepositoty(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
