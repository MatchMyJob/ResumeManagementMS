using Application.DTO.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IExperienceCommand
    {
        Task<Experience> InsertExp(Experience request);
        Task<Experience> UpdateExp(int id, ExperienceRequest request , Guid UserId);
        Task<Experience> DeleteExp(int id);
    }
}
