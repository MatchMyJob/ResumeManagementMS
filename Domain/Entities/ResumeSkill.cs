using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ResumeSkill
    {
        public required int SkillId {get; set;}   
        public required Skill Skill {get; set;}
        public required int ResumeId {get; set;}
        public required Resume Resume {get; set;}
    }
}