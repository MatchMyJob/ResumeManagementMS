using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IStudyService
    {
        Task<StudyResponse> CreateStudy(StudyDTO studyDTO);
        //Task<StudyType> GetStudyTypeID(int studyTypeId);
    }
}