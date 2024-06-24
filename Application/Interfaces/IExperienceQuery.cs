using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IExperienceQuery
    {
        Task<Experience> GetExperienceById(int Id);
        Task<List<Experience>> GetAllExperience();
    }
}
