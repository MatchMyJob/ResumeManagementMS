using Application.DTO.Request;
using Application.DTO.Response;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudyService
    {
        Task<StudyResponse> RegisterStudy(StudyRequest request);
        Task<StudyResponse> ModStudy(int Id,StudyRequest request);
        Task<StudyResponse> DeleteStudy(int Id);
    }
}
