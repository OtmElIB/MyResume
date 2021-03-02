using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class ProfessionalExperiencesViewComponent : ViewComponent
    {
        public ProfessionalExperiencesViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ProfessionalExperiences"));
        }
    }
}
