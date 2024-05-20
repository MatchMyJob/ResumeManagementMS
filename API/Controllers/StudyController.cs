using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using Application.UseCase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyController : ControllerBase
    {
        private readonly IStudyService _studyService;
        public StudyController(IStudyService studyService)
        {
            _studyService = studyService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(StudyResponse), 201)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> RegisterStudy(StudyRequest request)
        {

            try
            {
                var result = await _studyService.RegisterStudy(request);
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
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(StudyResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> ModStudy(int id, StudyRequest request)
        {
            try
            {
                var result = await _studyService.ModStudy(id, request);
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
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiError), 200)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> DeleteStudy(int id)
        {

            try
            {
                var result = await _studyService.DeleteStudy(id);
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

    }
}
