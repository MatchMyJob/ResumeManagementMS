using Application.DTO.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IResumeCommand
    {
        Task<Resume> InsertResume(Resume request);
        Task<Resume> UpdateResume(ResumeRequest request);
        Task<Resume> DeleteResume(Guid id);

    }
}
