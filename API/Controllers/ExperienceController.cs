using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTO;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceService _service;

        public ExperienceController(IExperienceService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> ExperiencePost(ExperienceDTO experienceRequest){
            var result =  await _service.CreateExperience(experienceRequest);
            return new JsonResult(result) {StatusCode = 201};
        }
    }
}