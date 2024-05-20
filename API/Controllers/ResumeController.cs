using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService _resumeService;
        public ResumeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResumeResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> GetResumeById(Guid id)
        {
            try
            {
                var result = await _resumeService.GetResumeById(id);
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (ExceptionSintaxError ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 400 };
            }
            catch (ExceptionNotFound ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 404 };
            }
            catch (InternalServerErrorException ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 500 };
            }
        }
        [HttpPut]
        [ProducesResponseType(typeof(ResumeResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> ModResume(ResumeRequest request)
        {
            try
            {
                var result = await _resumeService.UpdateResume(request);
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (ExceptionSintaxError ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 400 };
            }
            catch (ExceptionNotFound ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 404 };
            }
            catch (ExceptionConflict ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 404 };
            }
            catch (InternalServerErrorException ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 500 };
            }
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiError), 200)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> DeleteResume(Guid id)
        {
            try
            {
                var result = await _resumeService.Delete(id);
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (ExceptionNotFound ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 404 };
            }
            catch (InternalServerErrorException ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 500 };
            }
        }
        [HttpPost]
        [ProducesResponseType(typeof(StudyResponse), 201)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> RegisterResume(ResumeRequest request)
        {

            try
            {
                var result = await _resumeService.RegisterResume(request);
                return new JsonResult(result) { StatusCode = 201 };
            }
            catch (ExceptionSintaxError ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 400 };
            }
            catch (ExceptionConflict ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 409 };
            }
            catch (InternalServerErrorException ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 500 };
            }
        }
    }
}
