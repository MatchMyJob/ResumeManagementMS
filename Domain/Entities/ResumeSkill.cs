using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ResumeSkill
    {
        public int SkillId { get; set; }
        public Guid UserId { get; set; }
        public Skill skill { get; set; }
        public Resume resume { get; set; }
    }
}
