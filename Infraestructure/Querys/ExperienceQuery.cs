using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Querys
{
    public class ExperienceQuery : IExperienceQuery
    {
        private readonly AppDbContext _context;

        public ExperienceQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Experience> GetExperience(int experienceId)
        {
            var experience = _context.Experiences
            .FirstOrDefault(s => s.ExperienceId == experienceId);
            return await Task.FromResult(experience);
        }
    }
}