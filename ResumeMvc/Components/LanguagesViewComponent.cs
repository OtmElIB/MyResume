using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class LanguagesViewComponent : ViewComponent
    {
        private readonly ILanguagesService _languageService;
        private readonly IMapper _mapper;

        public LanguagesViewComponent(ILanguagesService languageService, IMapper mapper)
        {
            _languageService = languageService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(long personID)
        {
            var viewModel = new List<LanguageViewModel>();
            var response = _languageService.Where(x => x.PersonID == personID);
            if (response.IsSuccess)
            {
                foreach (var item in response.Content)
                {
                    viewModel.Add(_mapper.Map<LanguageViewModel>(item));
                }
            }

            return await Task.FromResult((IViewComponentResult)View("Languages", viewModel));
        }
    }
}
