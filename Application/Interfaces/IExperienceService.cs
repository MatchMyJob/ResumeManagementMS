using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IExperienceService
    {
        Task<ExperienceResponse> RegisterExperience(ExperienceRequest request);
        Task<ExperienceResponse> ModExperience(int Id, ExperienceRequest request);
        Task<ExperienceResponse> DeleteExperience(int Id);
    }
}
