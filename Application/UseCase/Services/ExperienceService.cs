using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.DTO;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceCommand _command;
        private readonly IExperienceQuery _query;

        public ExperienceService(IExperienceCommand command, IExperienceQuery query)
        {
            _command = command;
            _query = query;
        }

        public async Task<ExperienceResponse> CreateExperience(ExperienceDTO experienceDTO)
        {
            var experience = new Experience{
                ResumeId = experienceDTO.resumeId,
                CompanyName = experienceDTO.CompanyName,
                JobTitle = experienceDTO.JobTitle,
                Description = experienceDTO.Description,
                StartDate = experienceDTO.StartDate,
                EndDate = experienceDTO.EndDate,    
            };
            await _command.InsertExperience(experience);
            return new ExperienceResponse{
                ExperienceId = experience.ExperienceId,
                CompanyName = experience.CompanyName,
                JobTitle = experience.JobTitle,
                Description = experience.Description,
                StartDate = experience.StartDate,
                EndDate = experience.EndDate
            };
        }

        public async Task RemoveExperienceById(int experienceId)
        {
            var experience = await _query.GetExperience(experienceId);
            await _command.DeleteExperience(experience);
        }
    }
}