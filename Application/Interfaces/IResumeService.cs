using Application.DTO.Request;
using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IResumeService
    {
        Task<ResumeResponse> GetResumeById(Guid id);
        Task<ResumeResponse> UpdateResume(ResumeRequest request, Guid userid);
        Task<ResumeResponse> RegisterResume(ResumeRequest request, Guid userid);
        Task<ResumeResponse> Delete(Guid id);
    }
}
