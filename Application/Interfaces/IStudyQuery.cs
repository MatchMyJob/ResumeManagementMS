using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudyQuery
    {
        Task<List<Study>> GetStudybyType(int studytypeid);
        Task<Study> GetStudybyid(int Id);
        Task<List<Study>> GetAllStudys();
    }
}
