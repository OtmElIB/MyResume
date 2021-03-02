using AutoMapper;
using Repository.Models;
using ResumeMvc.ViewModels;

namespace ResumeMvc.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, PersonViewModel>();
        }
    }
}
