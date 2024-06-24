using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;


namespace Application.UseCase.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeQuery _query;
        private readonly IMapper _mapper;
        private readonly ISkillQuery _skillQuery;
        private readonly IStudyQuery _studyQuery;
        private readonly IExperienceQuery _experienceQuery;
        private readonly IResumeCommand _command;

        public ResumeService(IResumeQuery resumeQuery, IMapper Mapper, ISkillQuery skillQuery, IStudyQuery studyQuery, IResumeCommand command, IExperienceQuery experienceQuery)
        {
            _query = resumeQuery;
            _mapper = Mapper;
            _skillQuery = skillQuery;
            _studyQuery = studyQuery;
            _command = command;
            _experienceQuery = experienceQuery;
        }
        public async Task<ResumeResponse> GetResumeById(Guid id)
        {
            try
            {
                List<Experience> experience = await _experienceQuery.GetAllExperience();
                List<Study> studys = await _studyQuery.GetAllStudys();
                List<Skill> skills = await _skillQuery.GetAllSkill(0,100);
                var filteredExperiences = experience.Where(exp => exp.UserId == id).ToList();
                var filteredStudys = studys.Where(study => study.UserId == id).ToList();
                var filterSkill = skills.Where(skill => skill.ResumeSkill.Any(rs => rs.resume.UserId == id));
                var resumebyId = await _query.GetResumeById(id);
                if (resumebyId == null)
                {
                    throw new ExceptionSintaxError("No existe user con ese ID.");
                }
                else
                {
                    var resumeResponse = _mapper.Map<ResumeResponse>(resumebyId);
                    resumeResponse.experiences = _mapper.Map<List<ExperienceResponse>>(filteredExperiences);
                    resumeResponse.studys = _mapper.Map<List<StudyResponse>>(filteredStudys);
                    resumeResponse.skills = _mapper.Map<List<SkillResponse>>(filterSkill);
                    return resumeResponse;
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
            catch (InternalServerErrorException ex)
            {
                throw new InternalServerErrorException("Error: " + ex.Message);
            }

        }
        public async Task<ResumeResponse> UpdateResume(ResumeRequest request, Guid userid)
        {
            try
            {
                if (request == null)
                {
                    throw new ExceptionSintaxError("Solicitud incorrecta campos vacios.");
                }
                if (request.minimumSalary < 100000 || request.minimumSalary > 100000000)
                {
                    throw new ExceptionSintaxError("El salario mínimo debe ser mayor a $100.000 y menor a $100.000.000.");
                }
                if (string.IsNullOrWhiteSpace(request.description))
                {
                    throw new ExceptionSintaxError("La descripción no puede estar vacía.");
                }
                if (string.IsNullOrWhiteSpace(request.image))
                {
                    throw new ExceptionSintaxError("La imagen no puede estar vacía.");
                }
                Resume resumeup = await _query.GetResumeById(userid);
                if(resumeup == null)
                {
                    throw new ExceptionConflict("No existe resume con ese ID.");
                }
                else
                {
                    resumeup = await _command.UpdateResume(request, userid);
                    var response = _mapper.Map<ResumeResponse>(resumeup);
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
        public async Task<ResumeResponse> Delete(Guid id)
        {
            try
            {
                var resumedelete = await _query.GetResumeById(id);
                if (resumedelete != null)
                {
                    resumedelete = await _command.DeleteResume(id);
                    var response = _mapper.Map<ResumeResponse>(resumedelete);
                    return response;
                }
                else
                {
                    throw new ExceptionNotFound("No existe ningun user con ese id");
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
        public async Task<ResumeResponse> RegisterResume(ResumeRequest request, Guid userid)
        {
            try
            {
                if (request == null)
                {
                    throw new ExceptionSintaxError("Solicitud incorrecta campos vacios.");
                }
                var resume = await _query.GetResumeById(userid);
                if (resume != null)
                {
                    throw new ExceptionSintaxError("Ya existe usuario con ese ID.");
                }
                if (request.minimumSalary < 100000 || request.minimumSalary > 100000000)
                {
                    throw new ExceptionSintaxError("El salario mínimo debe ser mayor a $100.000 y menor a $100.000.000.");
                }
                if (string.IsNullOrWhiteSpace(request.description))
                {
                    throw new ExceptionSintaxError("La descripción no puede estar vacía.");
                }
                if (string.IsNullOrWhiteSpace(request.image))
                {
                    throw new ExceptionSintaxError("La imagen no puede estar vacía.");
                }

                var newResume = _mapper.Map<Resume>(request);
                newResume.UserId = userid;
                newResume = await _command.InsertResume(newResume);
                var response = _mapper.Map<ResumeResponse>(newResume);
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
    }
}
