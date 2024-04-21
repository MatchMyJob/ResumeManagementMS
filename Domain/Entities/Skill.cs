using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Skill
    {
        public int SkillId {get; set;}
        public string Name {get; set;}   

        public IList<ResumeSkill> ResumeSkills {get; set;}
    }
}