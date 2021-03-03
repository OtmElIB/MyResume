using AutoMapper;
using Repository.Models;
using ResumeMvc.ViewModels;

namespace ResumeMvc.Mapping
{
    /// <summary>
    /// AutoMapper Profile Pour Mapper les entities vers des ViewModels
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, PersonViewModel>();

            CreateMap<Link, LinkViewModel>();

            CreateMap<Skill, SkillViewModel>();

            CreateMap<Training, TrainingViewModel>();

            CreateMap<Distinction, DistinctionViewModel>();

            CreateMap<ProfessionalExperience, ProfessionalExperienceViewModel>();

            CreateMap<PEType, PETypeViewModel>();

            CreateMap<Task, TaskViewModel>();

            CreateMap<Technology, TechnologyViewModel>();

            CreateMap<Language, LanguageViewModel>();
        }
    }
}
