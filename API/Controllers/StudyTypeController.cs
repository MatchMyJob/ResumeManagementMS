using Application.DTO.Error;
using Application.DTO.Response;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyTypeController : ControllerBase
    {
        private readonly IStudyTypeService _studyTypeService;
        public StudyTypeController(IStudyTypeService studyTypeService)
        {
            _studyTypeService = studyTypeService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(StudyTypeResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> GetStudyType(int pagedNumber=0, int pagedSize=10)
        {
      
            try
            {
                var result = await _studyTypeService.GetAllStudyTypes(pagedNumber, pagedSize );
                return new JsonResult(result) { StatusCode = 200 };
            }
            catch (ExceptionSintaxError ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 400 };
            }
            catch (InternalServerErrorException ex)
            {
                return new JsonResult(new ApiError { message = ex.Message }) { StatusCode = 500 };
            }
            
        }
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StudyTypeResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> GetStudyTypeById(int id)
        {
            try
             {
                 var result = await _studyTypeService.GetStudyTypesById(id);
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
    }
}
