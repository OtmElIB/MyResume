using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class LinksViewComponent : ViewComponent
    {
        private readonly ILinksService _linkService;
        private readonly IMapper _mapper;

        public LinksViewComponent(ILinksService linkService, IMapper mapper)
        {
            _linkService = linkService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(long personID)
        {
            var viewModel = new List<LinkViewModel>();
            var response = _linkService.Where(x => x.PersonID == personID);
            if(response.IsSuccess)
            {
                foreach(var item in response.Content)
                {
                    viewModel.Add(_mapper.Map<LinkViewModel>(item));
                }
            }

            return await Task.FromResult((IViewComponentResult)View("Links", viewModel));
        }
    }
}
