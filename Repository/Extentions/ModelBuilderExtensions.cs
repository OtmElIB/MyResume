using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // PEType
            modelBuilder.Entity<PEType>()
                .HasData(
                   new PEType { ID = 1, Title = "Consultant" },
                   new PEType { ID = 2, Title = "Stage" }
            );

            // Language
            modelBuilder.Entity<Language>()
                .HasData(
                   new Language { ID = 1, Title = "Francais",Score = 90 },
                   new Language { ID = 2, Title = "Anglais", Score = 80 },
                   new Language { ID = 3, Title = "Arabe", Score = 100 }
            );

            // Skill
            modelBuilder.Entity<Skill>()
                .HasData(
                   new Skill { ID = 1, Title = "C# / TypeScript", Score = 90 },
                   new Skill { ID = 2, Title = "Asp.Net MVC / WebAPI ", Score = 80 },
                   new Skill { ID = 3, Title = "Asp.Net / Asp.Net Core", Score = 80 },
                   new Skill { ID = 4, Title = "SqlServer / MySql / PostgreSql", Score = 70 },
                   new Skill { ID = 5, Title = "EF / EF Core", Score = 90 },
                   new Skill { ID = 6, Title = "Visual Studio / Visual Stuio Code", Score = 85 },
                   new Skill { ID = 7, Title = "TFS / Git / Azure DevOps / GitHub", Score = 90 },
                   new Skill { ID = 8, Title = "TDD / BDD / nUnit / SpecFlow", Score = 80 }
            );

            // Link
            modelBuilder.Entity<Link>()
                .HasData(
                   new Link { ID = 1, Title = "LinkedIn", Url = "https://www.linkedin.com/in/otmane-el-ibaoui/" },
                   new Link { ID = 2, Title = "GitHub", Url = "https://github.com/OtmElIB" }
            );

            // Training
            modelBuilder.Entity<Training>()
                .HasData(
                   new Training { ID = 1, SchoolName = "EMSI", Title = "Ingénierie informatique option MIAGE", Year = 2016 }
            );

            // Distinction
            modelBuilder.Entity<Distinction>()
                .HasData(
                   new Distinction { ID = 1, Title = "2ème place au Microsoft Imagine Cup Maroc 2016" },
                   new Distinction { ID = 2, Title = "Bénévole au collectif Autisme Maroc 2016" },
                   new Distinction { ID = 3, Title = "Certifié MTA: Windows Server Administration Fundamentals" }
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
                    new Technology { ID = 34, Title = "Angular 5" }
            );
        }
    }
}
