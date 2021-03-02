using AutoMapper;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ResumeMvc.ViewModels;

namespace ResumeMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public HomeController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var response = _personService.FirstOrDefault(x => x.Name == "El Ibaoui Otmane");

            if (response.IsSuccess)
            {
                return View(_mapper.Map<PersonViewModel>(response.Content));
            }
            else
            {
                return NotFound();
            }
        }
    }
}
