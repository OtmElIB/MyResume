using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class ProfessionalExperiencesViewComponent : ViewComponent
    {
        private readonly IProfessionalExperiencesService _professionalExperiencesService;
        private readonly IMapper _mapper;

        public ProfessionalExperiencesViewComponent(IProfessionalExperiencesService professionalExperiencesService, IMapper mapper)
        {
            _professionalExperiencesService = professionalExperiencesService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(long personID)
        {
            var viewModel = new List<ProfessionalExperienceViewModel>();
            var response = _professionalExperiencesService.Where(x => x.PersonID == personID);
            if (response.IsSuccess)
            {
                foreach (var item in response.Content)
                {
                    viewModel.Add(_mapper.Map<ProfessionalExperienceViewModel>(item));
                }
            }

            return await Task.FromResult((IViewComponentResult)View("ProfessionalExperiences", viewModel));
        }
    }
}
