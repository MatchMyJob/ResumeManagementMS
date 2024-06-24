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
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceService _experienceService;
        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        [HttpPost]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(ExperienceResponse), 201)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> RegisterExperience([FromBody] ExperienceRequest request)
        {
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token
                var result = await _experienceService.RegisterExp(request,userId);
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
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(ExperienceResponse), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> ModExperience(int id, ExperienceRequest request)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token
            try
            {
                var result = await _experienceService.UpdateExperience(id, request, userId);
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
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(ApiError), 200)]
        [ProducesResponseType(typeof(ApiError), 400)]
        [ProducesResponseType(typeof(ApiError), 404)]
        [ProducesResponseType(typeof(ApiError), 409)]
        [ProducesResponseType(typeof(ApiError), 500)]
        public async Task<IActionResult> DeleteExperience(int id, Guid UserId)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token
            try
            {
                var result = await _experienceService.DeleteExp(id);
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
    }
}
