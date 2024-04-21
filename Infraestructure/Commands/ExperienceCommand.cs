using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Commands
{
    public class ExperienceCommand : IExperienceCommand
    {
        private readonly AppDbContext _context;

        public ExperienceCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertExperience(Experience experience)
        {
            _context.Add(experience);
            await _context.SaveChangesAsync(); 
        }
    }
}