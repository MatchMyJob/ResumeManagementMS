using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IExperienceService
    {
        Task<Experience> CreateExperience(ExperienceDTO experienceDTO);   
    }
}