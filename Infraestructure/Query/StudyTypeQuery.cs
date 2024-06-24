using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Query
{
    public class StudyTypeQuery : IStudyTypeQuery
    {
        private readonly AppDbContext _context;
        public StudyTypeQuery(AppDbContext DBcontext)
        {
            _context = DBcontext;
        }
        public async Task<StudyType> GetStudyTypeById(int Id)
        {
            try
            {
                return await _context.studyTypes.Include(st => st.StudyList).SingleOrDefaultAsync(st => st.StudyTypeId == Id);
            }
            catch (DbUpdateException) 
            {
                throw new ExceptionConflict("No existe ese StudyType");
            }
        }
        public async Task<List<StudyType>> GetAllStudyTypes(int pagedNumber, int pagedSize)
        {
            try
            {
                List<StudyType> studyTypes = await _context.studyTypes.Include(st => st.StudyList).Skip(pagedNumber).Take(pagedSize).ToListAsync();
                return studyTypes;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionSintaxError("No se puede obtener los studyTypes");
            }
        }
    }
}
