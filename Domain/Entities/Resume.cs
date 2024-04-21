using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resume
    {
       public int ResumeId { get; set; }
       public Guid UserId { get; set; }
       public string Description { get; set; }
       public int MinimunSalary { get; set; }
       public string? Image {get; set;}

       public IList<Experience> ExperienceList { get; set; }
       public IList<Study> StudyList { get; set; }
       public IList<ResumeSkill> ResumeSkills { get; set; }
    }
}