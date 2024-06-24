using Application.DTO.Error;
using Application.DTO.Request;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Command
{
    public class ExperienceCommand : IExperienceCommand
    {
        private readonly AppDbContext _context;
        public ExperienceCommand(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Experience> InsertExp(Experience experience)
        {
            try
            {
                var existExperience = await _context.experiences.FirstOrDefaultAsync(s => s.ExperienceId == experience.ExperienceId);
                if (existExperience != null)
                {
                    throw new ExceptionConflict("La experiencia ya se encuentra registrado");
                }
                await _context.experiences.AddAsync(experience);
                await _context.SaveChangesAsync();
                var newExperience = await _context.experiences
                    .FirstOrDefaultAsync(s => s.ExperienceId == experience.ExperienceId);
                return newExperience;

            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async Task<Experience> UpdateExp(int id,ExperienceRequest request, Guid UserId)
        {
            try
            {
                var experienceUpdate = await _context.experiences
                    .Include(r => r.resume)
                    .FirstOrDefaultAsync(e => (e.UserId == UserId && e.ExperienceId == id));

                if (experienceUpdate == null)
                {
                    throw new ExceptionNotFound("El user con id" + UserId + "no existe");
                }
                experienceUpdate.ExperienceId = id;
                experienceUpdate.UserId = UserId;
                experienceUpdate.CompanyName = request.CompanyName;
                experienceUpdate.JobTitle = request.jobTitle;
                experienceUpdate.jobDescription = request.jobDescription;
                experienceUpdate.StartDate = request.startDate;
                experienceUpdate.EndDate = request.endDate;
                await _context.SaveChangesAsync();
                return experienceUpdate;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async Task<Experience> DeleteExp(int id)
        {
            try
            {
                var experienceelete = await _context.experiences.FirstOrDefaultAsync(e => (e.ExperienceId == id));
                if (experienceelete == null)
                {
                    throw new ExceptionNotFound("La Experiencia con ese ID no ha sido encontrado");
                }
                _context.experiences.Remove(experienceelete);
                await _context.SaveChangesAsync();
                return experienceelete;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("Problema al eliminar la experiencia");
            }
        }
    }
}
