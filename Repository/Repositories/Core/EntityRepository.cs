using Microsoft.EntityFrameworkCore;
using Repository.Models.Core;
using Repository.Repositories.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repositories.Core
{
    public abstract class EntityRepository<TEntity, TKey> : IEntityRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {

        #region Properties

        protected DbContext DbContext;
        protected DbSet<TEntity> DbSet;


        #endregion

        #region Constructors

        /// <summary>
        /// Initailise une nouvelle instance de EntityRepository
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="dateTimeProvider">Fournisseur de date</param>
        protected EntityRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = dbContext.Set<TEntity>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inclusions des entités associées provenant de plusieurs relations.
        /// </summary>
        /// <returns>IQueryable de TEntity</returns>
        protected virtual IQueryable<TEntity> Include()
        {
            var query = this.DbSet.AsQueryable();

            return query;
        }


        /// <summary>
        /// Ajoute l'entité donnée au contexte sous-jacent à l'ensemble dans l'état Ajouté de telle sorte qu'elle sera insérée dans la base de données lors de l'appel de SaveChanges.
        /// </summary>
        /// <param name="entity">Entité donnée.</param>
        public virtual void Add(TEntity entity)
        {
            if (entity != null)
            {
                entity.CreationDate = DateTime.Now;
            }

            this.DbSet.Add(entity);
        }

        /// <summary>
        /// Ajoute la collection d'entités donnée dans le contexte sous-jacent à l'ensemble, chaque entité étant placée dans l'état Ajouté de telle sorte qu'elle sera insérée dans la base de données lors de l'appel de SaveChanges.
        /// </summary>
        /// <param name="entities">Collection d'entités.</param>
        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    entity.CreationDate = DateTime.Now;
                }
            }

            this.DbSet.AddRange(entities);
        }

        /// <summary>
        /// Définit les valeurs de ce dictionnaire en lisant les valeurs de l'objet donné. L'objet donné peut être de tout type. Toute propriété sur l'objet avec un nom qui correspond à un nom de propriété dans le dictionnaire et qui peut être lu sera lue. Les autres propriétés seront ignorées. Cela permet, par exemple, de copier des propriétés à partir de simples objets de transfert de données (DTO).
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="entity">The entity.</param>
        public virtual void Set(TKey key, TEntity entity)
        {
            if (key != null && entity != null)
            {
                var dbEntity = this.DbSet.Find(key);

                if (dbEntity != null)
                {

                    entity.CreationDate = dbEntity.CreationDate;
                    entity.ModificationDate = DateTime.Now;

                    this.UpdatePropertyValues(dbEntity, entity);
                }
            }
        }

        /// <summary>
        /// Supprime la collection d'entités donnée du contexte sous-jacent à l'ensemble, chaque entité étant placée dans l'état Supprimé de sorte qu'elle sera supprimée de la base de données lors de l'appel de SaveChanges.
        /// </summary>
        /// <param name="entities">Collection d'entités à supprimer.</param>
        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            if (entities != null)
            {
                this.DbSet.RemoveRange(entities);
            }
        }

        /// <summary>
        /// Marque l'entité donnée comme supprimée de sorte qu'elle sera supprimée de la base de données lors de l'appel de SaveChanges.
        /// </summary>
        /// <param name="entity">Entité à supprimer.</param>
        public virtual void Remove(TEntity entity)
        {
            if (entity != null)
            {
                this.DbSet.Remove(entity);
            }
        }

        /// <summary>
        /// Enregistre toutes les modifications apportées dans ce contexte à la base de données sous-jacente.
        /// </summary>
        /// <returns>Nombre d'entrées d'état écrites dans la base de données sous-jacente.</returns>
        public virtual int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }

        /// <summary>
        /// Enregistre de manière asynchrone toutes les modifications apportées dans ce contexte à la base de données sous-jacente.
        /// </summary>
        /// <returns>Une tâche qui représente l'opération de sauvegarde asynchrone. Le résultat de la tâche contient le nombre d'entrées d'état écrites dans la base de données sous-jacente.</returns>
        public virtual async Task<int> SaveChangesAsync()
        {
            return await this.DbContext.SaveChangesAsync();
        }

        #region Create



        /// <summary>
        /// Ajoute l'entité donnée et la sauvegarde en base de donnée.
        /// </summary>
        /// <param name="entity">Entité donnée.</param>
        /// <returns>Nombre d'entité créer</returns>
        public virtual int Create(TEntity entity)
        {
            this.Add(entity);
            return this.SaveChanges();
        }

        /// <summary>
        /// Ajoute l'entité donnée et la sauvegarde en base de donnée.
        /// </summary>
        /// <param name="entities">Collection d'entité.</param>
        /// <returns>Nombre d'entité créer</returns>
        public virtual int Create(IEnumerable<TEntity> entities)
        {
            this.AddRange(entities);
            return this.SaveChanges();
        }

        /// <summary>
        /// Ajoute l'entité donnée et la sauvegarde en base de donnée de manière asynchrone.
        /// </summary>
        /// <param name="entity">Entité donnée.</param>
        /// <returns>Une tâche qui représente l'opération de sauvegarde asynchrone. Le résultat de la tâche contient le nombre d'entités crées dans la base de données.</returns>
        public virtual Task<int> CreateAsync(TEntity entity)
        {
            this.Add(entity);
            return this.SaveChangesAsync();
        }

        /// <summary>
        /// Ajoute une collection d'entités donnée et la sauvegarde en base de donnée de manière asynchrone.
        /// </summary>
        /// <param name="entities">Collection d'entités données.</param>
        /// <returns>Une tâche qui représente l'opération de sauvegarde asynchrone. Le résultat de la tâche contient le nombre d'entités crées dans la base de données.</returns>
        public virtual Task<int> CreateAsync(IEnumerable<TEntity> entities)
        {
            this.AddRange(entities);
            return this.SaveChangesAsync();
        }

        #endregion

        #region Read
        

        public virtual TEntity Read(TKey key)
        {
            return this.Include().FirstOrDefault(x => x.ID.Equals(key));
        }

        public virtual List<TEntity> Read(params TKey[] keys)
        {
            return this.Include().Where(x => keys.Contains(x.ID)).ToList();
        }

        public virtual List<TEntity> Read(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Include().Where(predicate).ToList();
        }

        public virtual List<TEntity> Read(Expression<Func<TEntity, bool>> predicate, params string[] navigationPropertyPaths)
        {
            var query = this.DbSet.AsQueryable();
            foreach (var navigationPropertyPath in navigationPropertyPaths)
            {
                query = query.Include(navigationPropertyPath);
            }
            return query.Where(predicate).ToList();
        }

        public virtual Task<List<TEntity>> ReadAsync()
        {
            return this.Include().ToListAsync();
        }






        public virtual Task<TEntity> ReadAsync(TKey key)
        {
            return this.Include().FirstOrDefaultAsync(x => x.ID.Equals(key));
        }


        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Include().FirstOrDefault(predicate);
        }


        #endregion

        #region Update

        public virtual int Update(TKey key, TEntity entity)
        {
            var updateResult = 0;

            if (key != null && entity != null)
            {
                this.Set(key, entity);
                updateResult = this.SaveChanges();
            }

            return updateResult;
        }

        public virtual async Task<int> UpdateAsync(TKey key, TEntity entity)
        {
            var updateResult = 0;

            if (key != null && entity != null)
            {
                var dbEntity = this.DbSet.Find(key);

                if (dbEntity != null)
                {

                    entity.CreationDate = dbEntity.CreationDate;
                    entity.ModificationDate = DateTime.Now;

                    this.UpdatePropertyValues(dbEntity, entity);

                    updateResult = await this.SaveChangesAsync();
                }
            }

            return updateResult;
        }

        /// <summary>
        /// Définit les valeurs de ce dictionnaire en lisant les valeurs de l'objet donné. L'objet donné peut être de tout type. Toute propriété sur l'objet avec un nom qui correspond à un nom de propriété dans le dictionnaire et qui peut être lu sera lue. Les autres propriétés seront ignorées. Cela permet, par exemple, de copier des propriétés à partir de simples objets de transfert de données (DTO).
        /// </summary>
        /// <param name="dbEntity">Entité issue de la base de donnée.</param>
        /// <param name="entity">Entité donnée.</param>
        protected virtual void UpdatePropertyValues(TEntity dbEntity, TEntity entity)
        {
            this.DbContext.Entry<TEntity>(dbEntity).CurrentValues.SetValues(entity);
        }

        #endregion

        #region Delete

        public virtual int Delete()
        {
            var items = this.DbSet.ToList();
            this.RemoveRange(items);
            return this.SaveChanges();
        }

        public virtual int Delete(TKey key)
        {
            var item = this.DbSet.Find(key);
            this.Remove(item);
            return this.SaveChanges();
        }

        public virtual Task<int> DeleteAsync()
        {
            var items = this.DbSet.ToList();
            this.RemoveRange(items);
            return this.SaveChangesAsync();
        }


        public virtual Task<int> DeleteAsync(TKey key)
        {
            var item = this.DbSet.Find(key);
            this.Remove(item);
            return this.SaveChangesAsync();
        }



        #endregion


        #endregion
    }
}
