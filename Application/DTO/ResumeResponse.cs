using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class ResumeResponse
    {
       public int ResumeId { get; set; }
       public Guid UserId { get; set; }
       public string Description { get; set; }
       public int MinimunSalary { get; set; }
       public string? Image {get; set;}
       public ExperienceResponse Experiences {get; set;}
       public SkillResponse Skills {get; set;}
       public StudyResponse StudyTypes {get; set;}
    }
}