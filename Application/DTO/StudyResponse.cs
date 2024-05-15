using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.DTO
{
    public class StudyResponse
    {
        public int StudyId {get; set;}
        public string Description {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}

        public StudyTypeResponse StudyType {get; set;}

    }
    public class StudyTypeResponse{
        public int StudyTypeId {get; set;}
        public string Name {get; set;}  

    }
    
}