using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class ExperienceQuery : IExperienceQuery
    {
        private readonly AppDbContext _context;

        public ExperienceQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Experience> GetExperiencebyid(int Id)
        {
            try
            {
                return await _context.experiences
                    .SingleOrDefaultAsync(p => p.ExperienceId == Id);

            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("No existe experience con ese id");
            }
        }
    }
}
