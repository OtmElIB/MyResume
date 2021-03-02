using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class TrainingsViewComponent : ViewComponent
    {
        private readonly ITrainingsService _trainingService;
        private readonly IMapper _mapper;

        public TrainingsViewComponent(ITrainingsService trainingService, IMapper mapper)
        {
            _trainingService = trainingService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(long personID)
        {
            var viewModel = new List<TrainingViewModel>();
            var response = _trainingService.Where(x => x.PersonID == personID);
            if (response.IsSuccess)
            {
                foreach (var item in response.Content)
                {
                    viewModel.Add(_mapper.Map<TrainingViewModel>(item));
                }
            }

            return await Task.FromResult((IViewComponentResult)View("Trainings", viewModel));
        }
    }
}
