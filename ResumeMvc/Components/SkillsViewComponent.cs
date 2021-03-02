using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class SkillsViewComponent : ViewComponent
    {
        private readonly ISkillsService _skillService;
        private readonly IMapper _mapper;

        public SkillsViewComponent(ISkillsService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(long personID)
        {
            var viewModel = new List<SkillViewModel>();
            var reponse = _skillService.Where(x => x.PersonID == personID);
            if (reponse.IsSuccess)
            {
                foreach (var item in reponse.Content)
                {
                    viewModel.Add(_mapper.Map<SkillViewModel>(item));
                }
            }

            return await Task.FromResult((IViewComponentResult)View("Skills", viewModel));
        }
    }
}
