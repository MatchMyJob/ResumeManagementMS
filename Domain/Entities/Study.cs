using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Study
    {
        public required int StudyId {get; set;}
        public required string Description {get; set;}
        public required DateTime StartDate {get; set;}
        public required DateTime EndDate {get; set;}

        public required int ResumeId {get; set;}
        public required Resume Resume {get; set;}

        public required int StudyTypeId {get; set;}
        public required StudyType StudyType {get; set;}
    }
}