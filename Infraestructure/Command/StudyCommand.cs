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
    public class StudyCommand : IStudyCommand
    {
        private readonly AppDbContext _context;
        public StudyCommand(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Study> InsertStudy(Study study)
        {
            try
            {
                var existStudy = await _context.studys.FirstOrDefaultAsync(s => (s.StudyId == study.StudyId));
                if (existStudy != null)
                {
                    throw new ExceptionConflict("El usuario ya se encuentra registrado");
                }
                await _context.AddAsync(study);
                await _context.SaveChangesAsync();
                var newstudy = await _context.studys
                    .Include(r => r.resume)
                    .Include(st => st.studyType)
                    .FirstOrDefaultAsync(s => (s.StudyId == study.StudyId));
                return newstudy;

            }
            catch(DbUpdateException)
            {
                throw;
            }
        } 
        public async Task<Study> UpdateStudy(int StudyId, StudyRequest request, Guid userid)
        {
            try
            {
                var studyUpdate = await _context.studys
                    .Include(r => r.resume)
                    .Include(st => st.studyType)
                    .FirstOrDefaultAsync(s => s.StudyId == StudyId && s.UserId == userid);

                if (studyUpdate== null)
                {
                    throw new ExceptionNotFound("El user con id" +userid + "no existe");
                }
                studyUpdate.UserId = userid;
                studyUpdate.StudyTypeId = request.studyTypeId;
                studyUpdate.Description = request.description;
                studyUpdate.StarDate = request.startDate;
                studyUpdate.EndDate = request.endDate;
                await _context.SaveChangesAsync();
                return studyUpdate;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async Task<Study> DeleteStudy(int id)
        {
            try
            {
                var StudyDelete = await _context.studys.FirstOrDefaultAsync(s => s.StudyId==id);
                if(StudyDelete == null)
                {
                    throw new ExceptionNotFound("El Study con ese ID no ha sido encontrado");
                }
                _context.studys.Remove(StudyDelete);
                await _context.SaveChangesAsync();
                return StudyDelete;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("Problema al elimiinar el study");
            }
        }
    }
}
