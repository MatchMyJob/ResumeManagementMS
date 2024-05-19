using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IResumeCommand
    {
        Task InsertResume(Resume resume);
        Task DeleteResume(Resume resume);
    }
}