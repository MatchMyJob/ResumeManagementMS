using Application.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Response
{
    public class ExperienceResponse
    {
        public int experienceId {  get; set; }
        public string companyName { get; set; }
        public string jobTitle { get; set; }
        public string jobDescription { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set;}
    }
}
