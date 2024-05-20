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
    public class ResumeSkillService : IResumeSkillService
    {
        private readonly ISkillQuery _query;
        private readonly IMapper _mapper;
        private readonly IResumeSkillCommand _command;
        private readonly IResumeQuery _resumeQuery;

        public ResumeSkillService(ISkillQuery skillQuery, IMapper Mapper, IResumeSkillCommand resumeSkillCommand, IResumeQuery resumeQuery)
        {
            _query = skillQuery;
            _mapper = Mapper;
            _command = resumeSkillCommand;
            _resumeQuery = resumeQuery;
        }
        public async Task<SkillResponse> RegisterResumeSkill(ResumeSkillRequest request)
        {
            try
            {
                var existSkill = await _query.GetSkillById(request.skillId);
                if (existSkill == null)
                {
                    throw new ExceptionNotFound("No existe skill con ese ID");
                }
                var existUserid = await _resumeQuery.GetResumeById(request.UserId);
                if(existUserid == null)
                {
                    throw new ExceptionNotFound("No existe user con ese ID");
                }
                if(request == null)
                {
                    throw new ExceptionSintaxError("no se permiten campos vacios");
                }
                var newResumeSkill = _mapper.Map<ResumeSkill>(request);
                newResumeSkill = await _command.InsertResumeSkill(newResumeSkill);
                var response = _mapper.Map<SkillResponse>(newResumeSkill);
                response.name = existSkill.Name;
                return response;
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
        public async Task<string> DeleteResumeSkill(int Id)
        {
            try
            {
                var resumeskillDelete = await _query.GetSkillById(Id);
                if (resumeskillDelete != null)
                {
                    resumeskillDelete = await _command.DeleteResumeSkill(Id);
                    return null;
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
