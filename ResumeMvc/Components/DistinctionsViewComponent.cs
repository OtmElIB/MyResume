using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class DistinctionsViewComponent : ViewComponent
    {
        private readonly IDistinctionsService _distinctionService;
        private readonly IMapper _mapper;

        public DistinctionsViewComponent(IDistinctionsService distinctionService, IMapper mapper)
        {
            _distinctionService = distinctionService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(long personID)
        {
            var viewModel = new List<DistinctionViewModel>();
            var response = _distinctionService.Where(x => x.PersonID == personID);
            if (response.IsSuccess)
            {
                foreach (var item in response.Content)
                {
                    viewModel.Add(_mapper.Map<DistinctionViewModel>(item));
                }
            }

            return await Task.FromResult((IViewComponentResult)View("Distinctions", viewModel));
        }
    }
}
