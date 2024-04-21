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

        public ExperienceService(IExperienceCommand command)
        {
            _command = command;
        }

        public async Task<Experience> CreateExperience(ExperienceDTO experienceDTO)
        {
            var experience = new Experience{
                CompanyName = experienceDTO.CompanyName,
                JobTitle = experienceDTO.JobTitle,
                Description = experienceDTO.Description,
                StartDate = experienceDTO.StartDate,
                EndDate = experienceDTO.EndDate,    
            };
            await _command.InsertExperience(experience);
            return experience;
        }
    }
}