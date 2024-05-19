using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.DTO;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class StudyService : IStudyService
    {
        public readonly IStudyCommand _command;
        public readonly IStudyQuery _query;
        public readonly IStudyTypeQuery _studyTypeQuery;

        public StudyService(IStudyCommand command, IStudyTypeQuery studyTypeQuery, IStudyQuery query)
        {
            _command = command;
            _studyTypeQuery = studyTypeQuery;
            _query = query;
        }

        public async Task<StudyResponse> CreateStudy(StudyDTO studyDTO)
        {
        
            var study = new Study{
                ResumeId = studyDTO.ResumeId,
                StudyTypeId = studyDTO.StudyTypeId,
                Description = studyDTO.Description,
                StartDate = studyDTO.StartDate,
                EndDate = studyDTO.EndDate,
            };
            var studyType = _studyTypeQuery.GetStudyTypeById(study.StudyTypeId);
            await _command.InsertStudy(study);
            return new StudyResponse{
                StudyId = study.StudyId,
                StudyType = new StudyTypeResponse{
                   StudyTypeId = studyType.StudyTypeId,
                   Name = studyType.Name
                },
                Description = study.Description,
                StartDate = study.StartDate,
                EndDate = study.EndDate
            };
        }

        public async Task RemoveStudy(int studyId)
        {
            var study = await _query.GetStudy(studyId);
            await _command.DeleteStudy(study);
        }
    }
}