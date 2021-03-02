﻿using Business.Services.Implementations;
using Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories.Implementations;
using Repository.Repositories.Interfaces;

namespace ResumeMvc.Extentions
{
    public static class ServiceCollectionExtention
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<ILinkRepository, LinkRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<IDistinctionRepository, DistinctionRepository>();
            services.AddScoped<IProfessionalExperienceRepository, ProfessionalExperienceRepository>();
            services.AddScoped<IPETypeRepository, PETypeRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITechnologiesRepository, TechnologiesRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IDistinctionsService, DistinctionsService>();
            services.AddScoped<ILanguagesService, LanguagesService>();
            services.AddScoped<ILinksService, LinksService>();
            services.AddScoped<IProfessionalExperiencesService, ProfessionalExperiencesService>();
            services.AddScoped<ISkillsService, SkillsService>();
            services.AddScoped<ITrainingsService, TrainingsService>();
        }
    }
}
