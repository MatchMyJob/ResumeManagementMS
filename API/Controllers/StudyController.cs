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
    public class StudyController : ControllerBase
    {
        private readonly IStudyService _service;

        public StudyController(IStudyService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> StudyPost(StudyDTO studyRequest){
            var result = _service.CreateStudy(studyRequest);
            return new JsonResult(result) {StatusCode = 201};
        }
    }
}