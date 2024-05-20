using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceQuery _query;
        private readonly IMapper _mapper;
        private readonly IExperienceCommand _command;
        private readonly IResumeService _resumeService;

        public ExperienceService(IExperienceQuery query, IMapper mapper, IExperienceCommand command, IResumeService resumeService)
        {
            _query = query;
            _mapper = mapper;
            _command = command;
            _resumeService = resumeService;
        }

        public async Task<ExperienceResponse> RegisterExperience(ExperienceRequest request)
        {
             try
            {
                //var resumeid = await _resumeService.GetResumeById(request.UserId);
                /*if (request.UserId != resumeid.UserId)
                {
                    throw new ExceptionSintaxError("No existe user con ese ID.");
                }*/
                if(request.JobTitle == "")
                {
                    throw new ExceptionSintaxError("el titulo no puede estar vacio.");
                }
                if(request.Description == "")
                {
                    throw new ExceptionSintaxError("no puede estar la descripcion vacia.");
                }
                if (!DateTime.TryParse(request.startDate.ToString(), out DateTime stardate))
                {
                    throw new ExceptionSintaxError("Ingrese correctamente la fecha de inicio");
                }
                if (!DateTime.TryParse(request.endDate.ToString(), out DateTime enddate))
                {
                    throw new ExceptionSintaxError("Ingrese correctamente la fecha de fin");
                }
                var newExperience = _mapper.Map<Experience>(request);
                newExperience = await _command.InsertExperience(newExperience);
                var response = _mapper.Map<ExperienceResponse>(newExperience);
                return response;

            }
            catch (ExceptionSintaxError ex)
            {
                throw new ExceptionSintaxError("Error: " + ex.Message);
            }
            catch (InternalServerErrorException ex)
            {
                throw new InternalServerErrorException("Error: " + ex.Message);
            }
        }

        public async Task<ExperienceResponse> ModExperience(int Id, ExperienceRequest request)
        {
            try
            {
                if (request == null)
                {
                    throw new ExceptionSintaxError("Solicitud incorrecta campos vacios.");
                }
                var experienceup = await _query.GetExperiencebyid(Id);
                if (experienceup == null)
                {
                    throw new ExceptionNotFound("No existe experience con ese ID.");
                }
                else
                {
                    /*if (request.UserId == Guid.Empty)
                    {
                        throw new ExceptionSintaxError("El ID debe ser de tipo GUID.");
                    }*/
                    if (request.JobTitle == "")
                    {
                        throw new ExceptionSintaxError("el titulo no puede estar vacio.");
                    }
                    if (request.Description == "")
                    {
                        throw new ExceptionSintaxError("no puede estar la descripcion vacia.");
                    }
                    if (!DateTime.TryParse(request.startDate.ToString(), out DateTime stardate))
                    {
                        throw new ExceptionSintaxError("Ingrese correctamente la fecha de inicio");
                    }
                    if (!DateTime.TryParse(request.endDate.ToString(), out DateTime enddate))
                    {
                        throw new ExceptionSintaxError("Ingrese correctamente la fecha de fin");
                    }
                    var newExperience = await _command.UpdateExperience(Id, request);
                    var response = _mapper.Map<ExperienceResponse>(newExperience);
                    return response;
                }
            }
            catch (ExceptionSintaxError ex)
            {
                throw new ExceptionSintaxError("Error: " + ex.Message);
            }
            catch (ExceptionNotFound ex)
            {
                throw new ExceptionNotFound("Error: " + ex.Message);
            }
            catch (InternalServerErrorException ex)
            {
                throw new InternalServerErrorException("Error: " + ex.Message);
            }

        }

        public async Task<ExperienceResponse> DeleteExperience(int Id)
        {
            try
            {
                var experiencedelete = await _query.GetExperiencebyid(Id);
                if (experiencedelete != null)
                {
                    experiencedelete = await _command.DeleteExperience(Id);
                    var response = _mapper.Map<ExperienceResponse>(experiencedelete);
                    return response;
                }
                else
                {
                    throw new ExceptionNotFound("No existe ningun experience con ese id");
                }
            }
            catch (ExceptionSintaxError ex)
            {
                throw new ExceptionSintaxError("Error: " + ex.Message);
            }
            catch (ExceptionNotFound ex)
            {
                throw new ExceptionNotFound("Error: " + ex.Message);
            }
            catch (InternalServerErrorException ex)
            {
                throw new InternalServerErrorException("Error: " + ex.Message);
            }
        }
    }
}
