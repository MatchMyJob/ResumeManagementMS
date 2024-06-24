using Application.DTO.Error;
using Application.DTO.Response;
using Application.Interfaces;
using Application.UseCase.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(SkillResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> GetAllSkill(int pagedNumber=0, int pagedSize=10)
        {
            try
            {
                var result = await _skillService.GetAllSkill(pagedNumber, pagedSize);
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
        [ProducesResponseType(typeof(SkillResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> GetSkillById(int id)
        {
            try
            {
                var result = await _skillService.GetSkillById(id);
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
