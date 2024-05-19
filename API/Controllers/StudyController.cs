using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTO;
using Application.DTO.Response;
using Application.DTO.Error;
using Application.DTO.Pagination;
using AutoMapper;
using System.Net;



namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudyController : ControllerBase
    {
        private readonly IStudyService _service;
        private readonly IMapper _mapper;
        private HTTPResponse<Object> _response;

        public StudyController(IStudyService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> StudyPost(StudyDTO studyRequest)
        {
            var result = await _service.CreateStudy(studyRequest);
            return new JsonResult(result) { StatusCode = 200 };
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> StudyDelete(int id)
        {
            try
            {
                //var result = _service.RemoveStudy(id);
                //return new JsonResult(result) { StatusCode = 200 };
                await _service.RemoveStudy(id);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("A server error has occurred."))) { StatusCode = 500 };
            }

        }
    }
}