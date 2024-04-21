using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraestructure.Persistence;
using Application.Interfaces;
using Domain.Entities;

namespace Infraestructure.Querys
{
    public class StudyTypeQuery : IStudyTypeQuery
    {
        private readonly AppDbContext _context;

        public StudyTypeQuery(AppDbContext context)
        {
            _context = context;
        }

        public StudyType GetStudyTypeById(int studyTypeId)
        {
            var studyType = _context.StudiesTypes
            .FirstOrDefault(s => s.StudyTypeId == studyTypeId);

            return studyType;
        }
    }
}