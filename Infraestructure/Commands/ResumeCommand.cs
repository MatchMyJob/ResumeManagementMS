using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Commands
{
    public class ResumeCommand : IResumeCommand
    {
        private readonly AppDbContext _context;

        public ResumeCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertResume(Resume resume)
        {
            _context.Add(resume);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteResume(Resume resume)
        {
            _context.Remove(resume);
            await _context.SaveChangesAsync();
        }
    }
}