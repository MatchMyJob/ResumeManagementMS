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
    public class StudyTypeService : IStudyTypeService
    {
        private readonly IStudyTypeQuery _query;
        private readonly IMapper _mapper;

        public StudyTypeService(IStudyTypeQuery studyTypeQuery, IMapper Mapper)
        {
            _query = studyTypeQuery;
            _mapper = Mapper;
        }
        public async Task<List<StudyTypeResponse>> GetAllStudyTypes(int pagedNumber, int pagedSize)
        {
            List<StudyType> listStudyType = new ();
            List<StudyTypeResponse> listStudyTypesResponse = new ();
            try
            {
                listStudyType = await _query.GetAllStudyTypes(pagedNumber, pagedSize);
                listStudyType.ForEach(st =>
                {
                    var studyTypeResponse = _mapper.Map<StudyTypeResponse>(st);
                    listStudyTypesResponse.Add(studyTypeResponse);
                });
                return listStudyTypesResponse;
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

        public async Task<StudyTypeResponse> GetStudyTypesById(int id)
        {
            try
            {
                var studyTypeById = await _query.GetStudyTypeById(id);
                if(studyTypeById == null)
                {
                    throw new ExceptionNotFound("No existe StudyType con ese ID.");
                }
                else
                {
                    var studytypeResponse =  _mapper.Map<StudyTypeResponse>(studyTypeById); 
                    return studytypeResponse;
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
