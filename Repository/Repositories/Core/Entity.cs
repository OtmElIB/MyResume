using Repository.Repositories.Interfaces;
using System;

namespace Repository.Repositories.Core
{
    /// <summary>
    /// Représente l'entité de base
    /// </summary>
    /// <typeparam name="TKey">Type de la clée d'identification</typeparam>
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        #region Properties

        /// <summary>
        /// Obtient ou définit l'identifiant de l'instance
        /// </summary>
        public TKey ID { get; set; }

        /// <summary>
        /// Obtient ou définit la date de création de l'instance
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Obtient ou définit la date de modification de l'instance
        /// </summary>
        public DateTime? ModificationDate { get; set; }


        #endregion
    }
}
