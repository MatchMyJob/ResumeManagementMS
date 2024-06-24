using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Query
{
    public class ResumeQuery : IResumeQuery
    {
        private readonly AppDbContext _context;
        public ResumeQuery(AppDbContext DBcontext)
        {
            _context = DBcontext;
        }
        public async Task<Resume> GetResumeById(Guid Id)
        {
                return await _context.resumes
                    .Include(r => r.ExperienceList)
                    .Include(r => r.StudyList)
                    .Include(r => r.ResumeSkillList)
                    .SingleOrDefaultAsync(r => r.UserId == Id);
        }
    }
}
