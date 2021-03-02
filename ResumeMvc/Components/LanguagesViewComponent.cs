using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class LanguagesViewComponent : ViewComponent
    {
        public LanguagesViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Languages"));
        }
    }
}
