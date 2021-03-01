using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;

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
            Person(modelBuilder);
            Distinction(modelBuilder);
            Language(modelBuilder);
            Link(modelBuilder);
            PEType(modelBuilder);
            ProfessionalExperience(modelBuilder);
            Skill(modelBuilder);
            Task(modelBuilder);
            Technology(modelBuilder);
            Training(modelBuilder);
        }

        private void Person(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(x => x.ID);
            modelBuilder.Entity<Person>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Person>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.Address).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.PhoneNumber).IsRequired();
            modelBuilder.Entity<Person>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);




            modelBuilder.Entity<Person>().HasMany(c => c.Links).WithOne(e => e.Person).IsRequired();
            modelBuilder.Entity<Person>().HasMany(c => c.Skills).WithOne(e => e.Person).IsRequired();
            modelBuilder.Entity<Person>().HasMany(c => c.Languages).WithOne(e => e.Person).IsRequired();
            modelBuilder.Entity<Person>().HasMany(c => c.Trainings).WithOne(e => e.Person).IsRequired();
            modelBuilder.Entity<Person>().HasMany(c => c.Distinctions).WithOne(e => e.Person).IsRequired();
            modelBuilder.Entity<Person>().HasMany(c => c.ProfessionalExperiences).WithOne(e => e.Person).IsRequired();
        }

        private void Link(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>().HasKey(x => x.ID);
            modelBuilder.Entity<Link>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Link>().Property(x => x.Url).IsRequired();
            modelBuilder.Entity<Link>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void Skill(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasKey(x => x.ID);
            modelBuilder.Entity<Skill>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Skill>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Skill>().Property(x => x.Score).IsRequired();
            modelBuilder.Entity<Skill>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void Language(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasKey(x => x.ID);
            modelBuilder.Entity<Language>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Language>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Language>().Property(x => x.Score).IsRequired();
            modelBuilder.Entity<Language>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void Training(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Training>().HasKey(x => x.ID);
            modelBuilder.Entity<Training>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Training>().Property(x => x.SchoolName).IsRequired();
            modelBuilder.Entity<Training>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Training>().Property(x => x.Year).IsRequired();
            modelBuilder.Entity<Training>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void Distinction(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Distinction>().HasKey(x => x.ID);
            modelBuilder.Entity<Distinction>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Distinction>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Distinction>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void ProfessionalExperience(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessionalExperience>().HasKey(x => x.ID);
            modelBuilder.Entity<ProfessionalExperience>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProfessionalExperience>().Property(x => x.CompanyName).IsRequired();
            modelBuilder.Entity<ProfessionalExperience>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<ProfessionalExperience>().Property(x => x.StartDate).IsRequired();
            modelBuilder.Entity<ProfessionalExperience>().Property(x => x.EndDate).IsRequired();
            modelBuilder.Entity<ProfessionalExperience>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<ProfessionalExperience>().HasMany(c => c.Technologies).WithOne(e => e.ProfessionalExperience).IsRequired();
            modelBuilder.Entity<ProfessionalExperience>().HasMany(c => c.Tasks).WithOne(e => e.ProfessionalExperience).IsRequired();
        }

        private void Technology(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>().HasKey(x => x.ID);
            modelBuilder.Entity<Technology>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Technology>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Technology>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void Task(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().HasKey(x => x.ID);
            modelBuilder.Entity<Task>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Task>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Task>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);
        }

        private void PEType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PEType>().HasKey(x => x.ID);
            modelBuilder.Entity<PEType>().Property(x => x.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<PEType>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<PEType>().Property(x => x.CreationDate).IsRequired().HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<PEType>().HasMany(c => c.ProfessionalExperiences).WithOne(e => e.Type).IsRequired();
        }
    }
}
