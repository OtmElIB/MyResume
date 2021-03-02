using Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<Person> Get()
        {
            var response = _personService.FirstOrDefault(x => x.Name == "El Ibaoui Otmane");
            
            if (response.IsSuccess)
            { 
                return Ok(response.Content);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
