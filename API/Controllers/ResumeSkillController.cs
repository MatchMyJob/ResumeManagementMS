using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using Application.UseCase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeSkillController : ControllerBase
    {
        private readonly IResumeSkillService _resumeSkillService;
        public ResumeSkillController(IResumeSkillService resumeSkillService)
        {
            _resumeSkillService = resumeSkillService;
        }
        [HttpPost]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(SkillResponse), 201)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> RegisterResumeSkill(ResumeSkillRequest request)
        {
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var result = await _resumeSkillService.RegisterResumeSkill(request, userId);
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
        [HttpDelete("{id}")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(ApiError), 200)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> DeleteResumeSkill(int id)
        {
            try
            {
                var result = await _resumeSkillService.DeleteResumeSkill(id);
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
