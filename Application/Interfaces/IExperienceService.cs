using Application.DTO.Request;
using Application.DTO.Response;
using Azure.Core;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IExperienceService
    {
        Task<ExperienceResponse> RegisterExp(ExperienceRequest request, Guid UserId);
        Task<ExperienceResponse> UpdateExperience(int id, ExperienceRequest request, Guid UserId);
        Task<ExperienceResponse> DeleteExp(int id);
    }
}
