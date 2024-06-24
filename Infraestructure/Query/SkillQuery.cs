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
    public class SkillQuery : ISkillQuery
    {
        private readonly AppDbContext _context;
        public SkillQuery(AppDbContext DBcontext)
        {
            _context = DBcontext;
        }
        public async Task<Skill> GetSkillById(int id)
        {
            try
            {
                return await _context.skills.Include(s => s.ResumeSkill).SingleOrDefaultAsync(s => s.SkillId == id);
            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("No existe ese StudyType");
            }
        }
        public async Task<List<Skill>> GetAllSkill(int pagedNumber, int pagedSize)
        {
            try
            {
                List<Skill> skills = await _context.skills.Include(s => s.ResumeSkill).ThenInclude(r => r.resume).Skip(pagedNumber).Take(pagedSize).ToListAsync();
                return skills;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionSintaxError("No se puede obtener los studyTypes");
            }
        }
    }
}
