using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure.Persistence;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Querys
{
    public class StudyQuery : IStudyQuery
    {
        private readonly AppDbContext _context;

        public StudyQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Study> GetStudy(int studyId)
        {
            var study = await _context.Studies
            .FirstOrDefaultAsync(s => s.StudyId == studyId);
            return study;
        
        }
    }
}