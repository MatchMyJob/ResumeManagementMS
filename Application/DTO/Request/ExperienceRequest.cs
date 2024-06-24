using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class ExperienceRequest
    {
        //public Guid UserId { get; set; }
        public string CompanyName { get; set; }
        public string jobTitle {  get; set; }
        public string jobDescription { get; set; }
        public DateTime startDate {  get; set; }
        public DateTime endDate { get; set;}
    }
}
