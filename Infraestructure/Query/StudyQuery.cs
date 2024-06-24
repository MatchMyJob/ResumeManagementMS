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
    public class StudyQuery : IStudyQuery
    {
        private readonly AppDbContext _context;
        public StudyQuery(AppDbContext DBcontext)
        {
            _context = DBcontext;
        }
        public async Task<List<Study>> GetStudybyType(int Id)
        {
            try
            {
                List<Study> studys = await _context.studys
                    .Include(p => p.studyType)
                    .Include(p => p.resume)
                    .Where(p => p.studyType.StudyTypeId == Id)
                    .ToListAsync();
                return studys;


            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("studytype no encontrado"); 
            }
        }
        public async Task<Study> GetStudybyid(int Id)
        {
            try
            {
                return await _context.studys
                    .Include(p => p.studyType)
                    .Include(p => p.resume)
                    .SingleOrDefaultAsync(p => p.StudyId == Id);

            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("No existe study con ese id");
            }
        }
        public async Task<List<Study>> GetAllStudys()
        {
            try
            {
                List<Study> studys = await _context.studys.Include(st => st.studyType).Include(s => s.resume).ToListAsync();
                return studys;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionSintaxError("No se puede obtener los estudios");
            }
        }
    }
}
