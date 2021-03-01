using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Person
            modelBuilder.Entity<Person>()
                .HasData(
                   new Person
                   {
                       ID = 1,
                       Name = "El Ibaoui Otmane",
                       PhoneNumber = "0659058512",
                       Email = "otmelib@gmail.com",
                       Address = "52 rue gambetta, Levallois Perret 92300",
                       Title = "Consultant Microsoft .Net/.Net Core / C#"
                   }
            );

            // Proffessional Experience
            modelBuilder.Entity<ProfessionalExperience>()
                .HasData(
                   new ProfessionalExperience { ID = 1, PersonID = 1, TypeID = 1, CompanyName = "MNE", Title = "Consultant .Net Framework MVC/C# " },
                   new ProfessionalExperience { ID = 2, PersonID = 1, TypeID = 1, CompanyName = "CDsicount", Title = "Consultant FullStack .Net Framework" },
                   new ProfessionalExperience { ID = 3, PersonID = 1, TypeID = 1, CompanyName = "SMoney", Title = "Consultant FullStack .Net Framework" },
                   new ProfessionalExperience { ID = 4, PersonID = 1, TypeID = 1, CompanyName = "AFNOR", Title = "Consultant FullStack .Net Core" }
            );

            // PEType
            modelBuilder.Entity<PEType>()
                .HasData(
                   new PEType { ID = 1, Title = "Consultant" },
                   new PEType { ID = 2, Title = "Stage" }
            );

            // Language
            modelBuilder.Entity<Language>()
                .HasData(
                   new Language { ID = 1, Title = "Francais",Score = 90, PersonID = 1 },
                   new Language { ID = 2, Title = "Anglais", Score = 80, PersonID = 1 },
                   new Language { ID = 3, Title = "Arabe", Score = 100, PersonID = 1 }
            );

            // Skill
            modelBuilder.Entity<Skill>()
                .HasData(
                   new Skill { ID = 1, Title = "C# / TypeScript", Score = 90, PersonID = 1 },
                   new Skill { ID = 2, Title = "Asp.Net MVC / WebAPI ", Score = 80, PersonID = 1 },
                   new Skill { ID = 3, Title = "Asp.Net / Asp.Net Core", Score = 80, PersonID = 1 },
                   new Skill { ID = 4, Title = "SqlServer / MySql / PostgreSql", Score = 70, PersonID = 1 },
                   new Skill { ID = 5, Title = "EF / EF Core", Score = 90, PersonID = 1 },
                   new Skill { ID = 6, Title = "Visual Studio / Visual Stuio Code", Score = 85, PersonID = 1 },
                   new Skill { ID = 7, Title = "TFS / Git / Azure DevOps / GitHub", Score = 90, PersonID = 1 },
                   new Skill { ID = 8, Title = "TDD / BDD / nUnit / SpecFlow", Score = 80, PersonID = 1 }
            );

            // Link
            modelBuilder.Entity<Link>()
                .HasData(
                   new Link { ID = 1, Title = "LinkedIn", Url = "https://www.linkedin.com/in/otmane-el-ibaoui/", PersonID = 1 },
                   new Link { ID = 2, Title = "GitHub", Url = "https://github.com/OtmElIB", PersonID = 1 }
            );

            // Training
            modelBuilder.Entity<Training>()
                .HasData(
                   new Training { ID = 1, SchoolName = "EMSI", Title = "Ingénierie informatique option MIAGE", Year = 2016, PersonID = 1 }
            );

            // Distinction
            modelBuilder.Entity<Distinction>()
                .HasData(
                   new Distinction { ID = 1, Title = "2ème place au Microsoft Imagine Cup Maroc 2016", PersonID = 1 },
                   new Distinction { ID = 2, Title = "Bénévole au collectif Autisme Maroc 2016", PersonID = 1 },
                   new Distinction { ID = 3, Title = "Certifié MTA: Windows Server Administration Fundamentals", PersonID = 1 }
            );

            // Technology
            modelBuilder.Entity<Technology>()
                .HasData(
                    new Technology { ID = 1, Title = "Visual Studio 2015" },
                    new Technology { ID = 2, Title = "Visual Studio 2019" },
                    new Technology { ID = 3, Title = "Visual Studio Code" },
                    new Technology { ID = 4, Title = "TFS" },
                    new Technology { ID = 5, Title = "GIT" },
                    new Technology { ID = 6, Title = "Azure DevOps" },
                    new Technology { ID = 7, Title = "SqlServer 2012" },
                    new Technology { ID = 8, Title = "SqlServer 2016" },
                    new Technology { ID = 9, Title = "PostgreSql" },
                    new Technology { ID = 10, Title = "C#" },
                    new Technology { ID = 11, Title = "TypeScript" },
                    new Technology { ID = 12, Title = "JavaScript" },
                    new Technology { ID = 13, Title = "jQuery" },
                    new Technology { ID = 14, Title = "Asp.Net MVC 5" },
                    new Technology { ID = 15, Title = "Asp.Net MVC Core" },
                    new Technology { ID = 16, Title = "Asp.Net WebApi 2" },
                    new Technology { ID = 17, Title = "Asp.Net Core WebApi" },
                    new Technology { ID = 18, Title = "EntityFramework 6" },
                    new Technology { ID = 19, Title = "EntityFramework Core 3" },
                    new Technology { ID = 20, Title = "Html" },
                    new Technology { ID = 21, Title = "Css" },
                    new Technology { ID = 22, Title = "csHtml" },
                    new Technology { ID = 23, Title = "SQL" },
                    new Technology { ID = 24, Title = "EntityFramework 6" },
                    new Technology { ID = 25, Title = "nUnit" },
                    new Technology { ID = 26, Title = "SpecFlow" },
                    new Technology { ID = 27, Title = "AutoMapper" },
                    new Technology { ID = 28, Title = "FluentValidation" },
                    new Technology { ID = 29, Title = "RestSharp" },
                    new Technology { ID = 30, Title = "SonarLint" },
                    new Technology { ID = 31, Title = "FxCop" },
                    new Technology { ID = 32, Title = "Security Code Scan" },
                    new Technology { ID = 33, Title = "Application Insights" },
                    new Technology { ID = 34, Title = "PostMan" },
                    new Technology { ID = 35, Title = "Angular 5" }
            );

            // Task
            modelBuilder.Entity<Task>()
                .HasData(
                    new Task { ID = 1, ProfessionalExperienceID = 1, Title = "Migration de l'application web Massar de Silverlight vers Asp.Net MVC 5." },
                    new Task { ID = 2, ProfessionalExperienceID = 1, Title = "Evolution des services utilisés par l'application Massar" },
                    new Task { ID = 3, ProfessionalExperienceID = 1, Title = "Amélioration des performances (time processing, bug fixes et utilisation d'Api externes pour une meilleure user experience)" },
                    new Task { ID = 4, ProfessionalExperienceID = 1, Title = "Développement de nouvelles fonctionnalités" },
                    new Task { ID = 5, ProfessionalExperienceID = 1, Title = "Archivage et Shelve et Code Reviewsous TFS" },
                    new Task { ID = 6, ProfessionalExperienceID = 2, Title = "Maintenance et évolution des services utilisés par les applications Cdiscount" },
                    new Task { ID = 7, ProfessionalExperienceID = 2, Title = "Développement des nouvelles fonctionnalités sur les différents sites: Cdiscount Market Place,Seller Zone,Esus,GoSport,Cdiscount Pro" },
                    new Task { ID = 8, ProfessionalExperienceID = 2, Title = "Optimisation des performances" },
                    new Task { ID = 9, ProfessionalExperienceID = 2, Title = "Analyse et correction des bugs sur les différents sites" },
                    new Task { ID = 10, ProfessionalExperienceID = 2, Title = "Développement, tests unitaires et tests d'intégration" },
                    new Task { ID = 11, ProfessionalExperienceID = 2, Title = "Archivage, shelve, merge et Code Reviewsous TFS" },
                    new Task { ID = 12, ProfessionalExperienceID = 3, Title = "Développement des nouvelles fonctionnalités et maintenance des applications(l’Api et l’Espace partenaire) au sain de l’équipe cœur du métier de Smoney" },
                    new Task { ID = 13, ProfessionalExperienceID = 3, Title = "Analyse et correction desbugssurlesdifférentes applications" },
                    new Task { ID = 14, ProfessionalExperienceID = 3, Title = "AsDéveloppement de la nouvelle version de l’espace partenaire" },
                    new Task { ID = 15, ProfessionalExperienceID = 3, Title = "Conception, architecture etréalisation de la nouvelle application quisert de parcours d’inscription" },
                    new Task { ID = 16, ProfessionalExperienceID = 3, Title = "Développement destests unitaires surl’application" },
                    new Task { ID = 17, ProfessionalExperienceID = 3, Title = "Intégration continue via Azure DevOps" },
                    new Task { ID = 18, ProfessionalExperienceID = 3, Title = "Déploiement des applications et des différentes release su différents serveurs" },
                    new Task { ID = 19, ProfessionalExperienceID = 4, Title = "Refonte complète de la boutique normes (FrontOffice) qui sert à acheter et vendre ces dernières en utilisant la méthode Agile." },
                    new Task { ID = 20, ProfessionalExperienceID = 4, Title = "Validation et pesage des Uses Story avec l’équipe PO" },
                    new Task { ID = 21, ProfessionalExperienceID = 4, Title = "Développement des tests unitaires et fonctionnels " },
                    new Task { ID = 22, ProfessionalExperienceID = 4, Title = "Front End : intégration des maquettes développées par l’intégrateur" },
                    new Task { ID = 23, ProfessionalExperienceID = 4, Title = "Mise en place des architectures applicative du front office et back office" },
                    new Task { ID = 24, ProfessionalExperienceID = 4, Title = "Développements de la partie parcours d’achats et l’espace personnel du site et paiement CB(ATOS)" },
                    new Task { ID = 25, ProfessionalExperienceID = 4, Title = "Participation au développements du nouveau Framework qui sera par la suite utilisé par le reste des équipes" },
                    new Task { ID = 26, ProfessionalExperienceID = 4, Title = "Création de micro services pour chaque application tier" },
                    new Task { ID = 27, ProfessionalExperienceID = 4, Title = "Déploiement et intégration continue via Azure DevOps" }
            );            
        }
    }
}
