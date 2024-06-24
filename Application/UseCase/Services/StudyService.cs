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

namespace Application.UseCase.Services
{
    public class StudyService : IStudyService
    {
        private readonly IStudyQuery _query;
        private readonly IMapper _mapper;
        private readonly IStudyCommand _command;
        private readonly IResumeService _resumeService;

        public StudyService(IStudyQuery Query, IMapper Mapper, IStudyCommand studyCommand, IResumeService resumeService)
        {
            _query = Query;
            _mapper = Mapper;
            _command = studyCommand;
            _resumeService = resumeService;
        }
        public async Task<StudyResponse> RegisterStudy(StudyRequest request, Guid userid)
        {
            try
            {
                var resumeid = await _resumeService.GetResumeById(userid);
                if (userid != resumeid.UserId)
                {
                    throw new ExceptionSintaxError("No existe user con ese ID.");
                }
                if (request.studyTypeId < 1 || request.studyTypeId > 8)
                {
                    throw new ExceptionSintaxError("el studytypeid debe ser entre 1 y 8 1. Primaria, 2.Secundaria, 3.Terciario, 4.Universitario, 5.Posgrado, 6.Master, 7.Doctorado, 8.Curso");
                }
                if(request.description == "")
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
                var newStudy = _mapper.Map<Study>(request);
                newStudy.UserId = userid;
                newStudy = await _command.InsertStudy(newStudy);
                var response = _mapper.Map<StudyResponse>(newStudy);
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
        public async Task<StudyResponse> ModStudy(int Id, StudyRequest request, Guid userid)
        {
            try
            {
                if (request == null)
                {
                    throw new ExceptionSintaxError("Solicitud incorrecta campos vacios.");
                }
                var studyup = await _query.GetStudybyType(Id);
                if (studyup == null)
                {
                    throw new ExceptionNotFound("No existe study con ese ID.");
                }
                else
                {
                    if (userid == Guid.Empty)
                    {
                        throw new ExceptionSintaxError("El ID debe ser de tipo GUID.");
                    }
                    if (request.studyTypeId < 1 || request.studyTypeId > 8)
                    {
                        throw new ExceptionSintaxError("el studytypeid debe ser entre 1 y 8 1. Primaria, 2.Secundaria, 3.Terciario, 4.Universitario, 5.Posgrado, 6.Master, 7.Doctorado, 8.Curso");
                    }
                    if (request.description == "")
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
                    var newStudy2 = new Study
                    {
                        StudyId = Id,
                        StudyTypeId = request.studyTypeId,
                        Description = request.description,
                        StarDate = stardate,
                        EndDate = enddate
                    };
                    newStudy2.studyType = newStudy2.studyType ?? new StudyType
                    {
                        StudyTypeId = request.studyTypeId,
                        Name = "Genérico" // Nombre por defecto
                    };
                    newStudy2 = await _command.UpdateStudy(Id, request, userid);
                    if (newStudy2 == null)
                    {
                        throw new ExceptionNotFound("Error al actualizar el estudio.");
                    }
                    var response = _mapper.Map<StudyResponse>(newStudy2);

                    // Asignar siempre un StudyTypeResponse, incluso si studyType es null
                    response.studyType = new StudyTypeResponse
                    {
                        StudyTypeId = newStudy2.StudyTypeId,
                        name = newStudy2.studyType?.Name ?? "Genérico" // Manejar null con un valor por defecto
                    };

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
        public async Task<StudyResponse> DeleteStudy(int id)
        {
            try
            {
                var studydelete = await _query.GetStudybyid(id);
                if (studydelete != null)
                {
                    studydelete = await _command.DeleteStudy(id);
                    var response = _mapper.Map<StudyResponse>(studydelete);
                    return response;
                }
                else
                {
                    throw new ExceptionNotFound("No existe ningun study con ese id");
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
