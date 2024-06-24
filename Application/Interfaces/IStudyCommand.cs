using Application.DTO.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudyCommand
    {
        Task<Study> InsertStudy(Study study);
        Task<Study> UpdateStudy(int StudyId, StudyRequest request, Guid userid);
        Task<Study> DeleteStudy(int id);
    }
}
