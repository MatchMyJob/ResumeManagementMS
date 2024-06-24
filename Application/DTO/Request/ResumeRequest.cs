using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class ResumeRequest
    {
        //public Guid UserId { get; set; }
        public string description { get; set; }
        public int minimumSalary { get; set; }
        public string image {  get; set; }
    }
}
