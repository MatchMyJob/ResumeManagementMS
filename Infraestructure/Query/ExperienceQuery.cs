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
    public class ExperienceQuery : IExperienceQuery
    {
        private readonly AppDbContext _context;
        public ExperienceQuery(AppDbContext DBcontext)
        {
            _context = DBcontext;
        }
        public async Task<Experience> GetExperienceById(int Id)
        {
            return await _context.experiences
                .Include(r => r.resume)
                .SingleOrDefaultAsync(e => e.ExperienceId == Id);
        }
        public async Task<List<Experience>> GetAllExperience()
        {
            try
            {
                List<Experience> experiences = await _context.experiences.Include(r => r.resume).ToListAsync();
                return experiences;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionSintaxError("No se puede obtener las experiencias");
            }
        }
    }
}
