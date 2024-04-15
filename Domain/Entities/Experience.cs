using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Experience
    {
        public required int ExperienceId { get; set; }
        public required string CompanyName { get; set; }
        public required string JobTitle { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public required int ResumeId { get; set; }
        public required Resume Resume {get; set;}
    }
}