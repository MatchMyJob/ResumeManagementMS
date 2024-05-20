﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resume
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public int MinimumSalary { get; set; }
        public string Image { get; set; }
        
        public ICollection<Experience> ExperienceList { get; set; }
        public ICollection<Study> StudyList { get; set; }
        public ICollection<ResumeSkill> ResumeSkillList { get; set;}
    }
}
