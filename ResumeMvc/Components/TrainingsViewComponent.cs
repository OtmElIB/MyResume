using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class TrainingsViewComponent : ViewComponent
    {
        public TrainingsViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Trainings"));
        }
    }
}
