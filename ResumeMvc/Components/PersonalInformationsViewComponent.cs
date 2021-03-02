using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class PersonalInformationsViewComponent : ViewComponent
    {
        public PersonalInformationsViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("PersonalInformations"));
        }
    }
}
