using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class LinksViewComponent : ViewComponent
    {
        public LinksViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Links"));
        }
    }
}
