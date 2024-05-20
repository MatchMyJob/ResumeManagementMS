using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Error;
using Application.DTO.Request;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class ExperienceCommand : IExperienceCommand
    {
        private readonly AppDbContext _context;

        public ExperienceCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Experience> InsertExperience(Experience experience)
        {
            try
            {
                var existExperience = await _context.experiences.FirstOrDefaultAsync(s => s.ExperienceId == experience.ExperienceId);
                if (existExperience != null)
                {
                    throw new ExceptionConflict("El usuario ya se encuentra registrado");
                }
                await _context.AddAsync(experience);
                await _context.SaveChangesAsync();
                var newExperience = await _context.experiences
                    .FirstOrDefaultAsync(s => s.ExperienceId == experience.ExperienceId);
                return newExperience;

            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task<Experience> UpdateExperience(int ExperienceId, ExperienceRequest request)
        {
            try
            {
                var experienceUpdate = await _context.experiences
                    .FirstOrDefaultAsync(s => s.ExperienceId == ExperienceId && s.UserId == request.UserId);

                if (experienceUpdate== null)
                {
                    throw new ExceptionNotFound("El user con id" +request.UserId+ "no existe");
                }
                experienceUpdate.UserId = request.UserId;
                experienceUpdate.CompanyName  = request.CompanyName;
                experienceUpdate.JobTitle = request.JobTitle;
                experienceUpdate.Description = request.Description;
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

        public async Task<Experience> DeleteExperience(int id)
        {
            try
            {
                var ExperienceDelete = await _context.experiences.FirstOrDefaultAsync(s => s.ExperienceId==id);
                if(ExperienceDelete == null)
                {
                    throw new ExceptionNotFound("El Experience con ese ID no ha sido encontrado");
                }
                _context.experiences.Remove(ExperienceDelete);
                await _context.SaveChangesAsync();
                return ExperienceDelete;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("Problema al elimiinar el experience");
            }
        }
    }
}
