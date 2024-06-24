using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISkillQuery
    {
        Task<Skill> GetSkillById(int id);
        Task<List<Skill>> GetAllSkill(int pagedNumber, int pagedSize);
    }
}
