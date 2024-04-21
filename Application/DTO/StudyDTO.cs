using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class StudyDTO
    {
        public int ResumeId {get; set;}
        public int StudyTypeId {get; set;}
        public string Description {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}

    }
}