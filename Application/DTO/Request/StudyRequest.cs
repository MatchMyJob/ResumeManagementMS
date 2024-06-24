using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class StudyRequest
    {
        //public Guid UserId { get; set; }
        public int studyTypeId { get; set; }
        public string description { get; set; }
        public DateTime startDate {  get; set; }
        public DateTime endDate { get; set;}
    }
}
