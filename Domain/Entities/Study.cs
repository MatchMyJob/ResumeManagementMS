using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Study
    {
        public int StudyId {get; set;}
        public string Description {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}

        public int ResumeId {get; set;}
        public  Resume Resume {get; set;}

        public  int StudyTypeId {get; set;}
        public  StudyType StudyType {get; set;}
    }
}