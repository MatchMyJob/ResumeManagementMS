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
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService _service;

        public ResumeController(IResumeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> ResumePost(ResumeDTO resumeRequest){
            var result = await _service.CreateResume(resumeRequest);
            return new JsonResult(result) {StatusCode = 201};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            var result = await _service.GetResumeByID(id);
            return new JsonResult(result);
        }
    }
}