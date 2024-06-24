using Application.DTO.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISkillService
    {
        Task<SkillResponse> GetSkillById(int id);
        Task<List<SkillResponse>> GetAllSkill(int pagedNumber, int pagedSize);
    }
}
