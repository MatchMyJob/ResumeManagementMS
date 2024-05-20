using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IExperienceCommand
    {
        Task<Experience> InsertExperience(Experience experience);
        Task<Experience> UpdateExperience(int ExperienceId, ExperienceRequest request);
        Task<Experience> DeleteExperience(int id);
    }
}
