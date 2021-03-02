using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResumeMvc.Components
{
    public class DistinctionsViewComponent : ViewComponent
    {
        public DistinctionsViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Distinctions"));
        }
    }
}
