using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Response
{
    public class ResumeResponse
    {
        public Guid UserId { get; set; }
        public string description { get; set; }
        public int minimumSalary { get; set; }
        public string image {  get; set; }
        public ExperienceResponse experiences { get; set; }
        public SkillResponse skills { get; set; }
        public StudyResponse studyTypes { get; set; }
    }
}
