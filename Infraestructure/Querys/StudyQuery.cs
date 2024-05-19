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
            var study = _context.Studies
            .FirstOrDefault(s => s.StudyId == studyId);
            return await Task.FromResult(study);
        
        }
    }
}