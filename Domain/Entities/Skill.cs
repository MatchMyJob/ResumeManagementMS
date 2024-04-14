using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Skill
    {
        public required int SkillId {get; set;}
        public required string Name {get; set;}   
    }
}