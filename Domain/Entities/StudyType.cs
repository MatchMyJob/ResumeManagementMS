using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudyType
    {
        public required int StudyTypeId {get; set;}
        public required string Name {get; set;}  

        public required IList<Study> StudyList {get; set;}  
    }
}