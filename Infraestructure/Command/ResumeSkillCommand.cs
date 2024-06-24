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

namespace Infraestructure.Command
{
    public class ResumeSkillCommand : IResumeSkillCommand
    {
        private readonly AppDbContext _context;
        public ResumeSkillCommand(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResumeSkill> InsertResumeSkill(ResumeSkill resumeSkill)
        {
            try
            {
                var existResumeSkill = await _context.resumeSkills.FirstOrDefaultAsync(s => s.SkillId == resumeSkill.SkillId && s.UserId == resumeSkill.UserId);
                if (existResumeSkill != null)
                {
                    throw new ExceptionConflict("El ResumenSkill ya existe");
                }
                await _context.AddAsync(resumeSkill);
                await _context.SaveChangesAsync();
                var newResumeSkill = await _context.resumeSkills
                    .Include(r => r.resume)
                    .Include(s => s.skill)
                    .FirstOrDefaultAsync(rs => rs.SkillId == resumeSkill.SkillId && rs.UserId == resumeSkill.UserId);
                return newResumeSkill;

            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async Task<Skill> DeleteResumeSkill(int id)
        {
            try
            {
                var resumeSkillDelete = await _context.resumeSkills.FirstOrDefaultAsync(s => s.SkillId == id);
                if (resumeSkillDelete == null)
                {
                    throw new ExceptionNotFound("El resumeskill con ese ID no ha sido encontrado");
                }
                _context.resumeSkills.Remove(resumeSkillDelete);
                await _context.SaveChangesAsync();
                return null;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("Problema al elimiinar el resumeskill");
            }
        }
    }
}
