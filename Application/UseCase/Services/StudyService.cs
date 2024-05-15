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
        public readonly IStudyTypeQuery _studyTypeQuery;

        public StudyService(IStudyCommand command , IStudyTypeQuery studyTypeQuery)
        {
            _command = command;
            _studyTypeQuery = studyTypeQuery;
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
    }
}