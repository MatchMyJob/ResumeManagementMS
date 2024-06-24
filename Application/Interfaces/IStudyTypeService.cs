using Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudyTypeService
    {
        Task<List<StudyTypeResponse>> GetAllStudyTypes(int pagedNumber, int pagedSize);
        Task<StudyTypeResponse> GetStudyTypesById(int id);
    }
}
