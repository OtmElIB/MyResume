using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Remplacez cette méthode pour configurer davantage le modèle découvert par convention des types d'entité exposés dans les propriétés DbSet TEntity dans votre contexte dérivé.
        /// Le modèle résultant peut être mis en cache et réutilisé pour des instances ultérieures de votre contexte dérivé.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
