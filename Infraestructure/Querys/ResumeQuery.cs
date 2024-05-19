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
    public class ResumeQuery : IResumeQuery
    {
        private readonly AppDbContext _context;

        public ResumeQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Resume> GetResume(int resumeId)
        {
            var resume = _context.Resumes
            .FirstOrDefault(s => s.ResumeId == resumeId);
            return await Task.FromResult(resume);
        }
    }
}