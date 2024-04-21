using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudyType
    {
        public int StudyTypeId {get; set;}
        public required string Name {get; set;}  

        public IList<Study> StudyList {get; set;}  
    }
}