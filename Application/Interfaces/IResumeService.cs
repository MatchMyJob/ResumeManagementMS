using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IResumeService
    {
        Task<Resume> CreateResume(ResumeDTO resumeDTO);
    }
}