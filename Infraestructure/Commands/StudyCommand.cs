using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure.Persistence;
using Domain.Entities;
using Application.Interfaces;

namespace Infraestructure.Commands
{
    public class StudyCommand : IStudyCommand
    {
        public readonly AppDbContext _context;

        public StudyCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertStudy(Study study)
        {
            _context.Add(study);
            await _context.SaveChangesAsync();
        }
    }
}