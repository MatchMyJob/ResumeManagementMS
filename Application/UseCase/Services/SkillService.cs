using Application.DTO.Error;
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
    public class SkillService : ISkillService
    {
        private readonly ISkillQuery _query;
        private readonly IMapper _mapper;

        public SkillService(ISkillQuery skillQuery, IMapper Mapper)
        {
            _query = skillQuery;
            _mapper = Mapper;
        }
        public async Task<SkillResponse> GetSkillById(int id)
        {
            try
            {
                var skillbyid = await _query.GetSkillById(id);
                if (skillbyid == null)
                {
                    throw new ExceptionNotFound("No existe skill con ese ID.");
                }
                else
                {
                    var skillResponse = _mapper.Map<SkillResponse>(skillbyid);
                    return skillResponse;
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
        public async Task<List<SkillResponse>> GetAllSkill(int pagedNumber, int pagedSize)
        {
            List<Skill> listskills = new();
            List<SkillResponse> listSkillsResponse = new();
            try
            {
                if (pagedNumber < 0 || pagedSize < 10) 
                {
                    throw new ExceptionSintaxError("Ingrese valores mayores que cero (0) para pageNumber y (10) para pageSize");
                }
                listskills = await _query.GetAllSkill(pagedNumber, pagedSize);
                listskills.ForEach(st =>
                {
                    var skillResponse = _mapper.Map<SkillResponse>(st);
                    listSkillsResponse.Add(skillResponse);
                });
                return listSkillsResponse;
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
    }
}
