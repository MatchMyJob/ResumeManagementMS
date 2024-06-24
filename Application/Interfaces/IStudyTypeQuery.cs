using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudyTypeQuery
    {
        Task<StudyType> GetStudyTypeById(int Id);
        Task<List<StudyType>> GetAllStudyTypes(int pagedNumber, int pagedSize);
    }
}
