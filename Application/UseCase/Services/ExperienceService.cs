using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Application.UseCase.Services
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceQuery _expquery;
        private readonly IExperienceCommand _expcommand;
        private readonly IMapper _mapper;
        private readonly IResumeQuery _resumequery;
        public ExperienceService(IExperienceQuery experienceQuery, IExperienceCommand experienceCommand, IMapper mapper, IResumeQuery resumeQuery) 
        {
            _expquery = experienceQuery;
            _expcommand = experienceCommand;
            _mapper = mapper;
            _resumequery = resumeQuery;
        }
        //para que no retorne nada hay que hacer task, sin esperar un response.
        public async Task<ExperienceResponse> RegisterExp(ExperienceRequest request, Guid UserId)
        {
            try
            {
                if(request == null)
                {
                    throw new ExceptionSintaxError("No pueden tener campos vacios");
                }
                var existUser = await _resumequery.GetResumeById(UserId);
                if (existUser == null)
                {
                    throw new ExceptionSintaxError("No existe User con ese ID");
                }
                if (string.IsNullOrWhiteSpace(request.CompanyName))
                {
                    throw new ExceptionSintaxError("La compañia no puede estar vacía.");
                }
                if (string.IsNullOrWhiteSpace(request.jobTitle))
                {
                    throw new ExceptionSintaxError("El titulo del trabajo no puede estar vacio.");
                }
                if (string.IsNullOrWhiteSpace(request.jobDescription))
                {
                    throw new ExceptionSintaxError("La descripcion del trabajo no puede estar vacio.");
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
                //guardar nuevo id con el id extraido del token.
                newExperience.UserId = UserId;
                newExperience = await _expcommand.InsertExp(newExperience);
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
            catch (Exception ex)
            {
                throw new Exception("Error inesperado: " + ex.Message);
            }
        }
        public async Task<ExperienceResponse> UpdateExperience(int id, ExperienceRequest request, Guid UserId)
        {

            try
            {
                if (request == null)
                {
                    throw new ExceptionSintaxError("Solicitud incorrecta campos vacios.");
                }
                Experience experienceup = await _expquery.GetExperienceById(id);
                if( experienceup == null)
                {
                    throw new ExceptionConflict("No existe experiencia asociada ese UserId.");
                }
                else
                {
                    var existUser = await _resumequery.GetResumeById(UserId);
                    if (existUser == null)
                    {
                        throw new ExceptionSintaxError("No existe User con ese ID");
                    }
                    if (string.IsNullOrWhiteSpace(request.CompanyName))
                    {
                        throw new ExceptionSintaxError("La compañia no puede estar vacía.");
                    }
                    if (string.IsNullOrWhiteSpace(request.jobTitle))
                    {
                        throw new ExceptionSintaxError("El titulo del trabajo no puede estar vacio.");
                    }
                    if (string.IsNullOrWhiteSpace(request.jobDescription))
                    {
                        throw new ExceptionSintaxError("La descripcion del trabajo no puede estar vacio.");
                    }
                    if (!DateTime.TryParse(request.startDate.ToString(), out DateTime stardate))
                    {
                        throw new ExceptionSintaxError("Ingrese correctamente la fecha de inicio");
                    }
                    if (!DateTime.TryParse(request.endDate.ToString(), out DateTime enddate))
                    {
                        throw new ExceptionSintaxError("Ingrese correctamente la fecha de fin");
                    }
                    experienceup = await _expcommand.UpdateExp(id,request,UserId);
                    var response = _mapper.Map<ExperienceResponse>(experienceup);
                    return response;
                }
            }
            catch (ExceptionSintaxError ex)
            {
                throw new ExceptionSintaxError(ex.Message);
            }
            catch (ExceptionNotFound ex)
            {
                throw new ExceptionNotFound("Error: " + ex.Message);
            }
            catch (ExceptionConflict ex)
            {
                throw new ExceptionNotFound("Error: " + ex.Message);
            }
            catch (InternalServerErrorException ex)
            {
                throw new InternalServerErrorException("Error: " + ex.Message);
            }
        }
        public async Task<ExperienceResponse> DeleteExp(int id)
        {
            try
            {
                var experienceDelete = await _expquery.GetExperienceById(id);
                if (experienceDelete != null)
                {
                    experienceDelete = await _expcommand.DeleteExp(id);
                    var response = _mapper.Map<ExperienceResponse>(experienceDelete);
                    return response;
                }
                else
                {
                    throw new ExceptionNotFound("No existe ninguna experiencia con ese id");
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
