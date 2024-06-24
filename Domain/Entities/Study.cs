using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Study
    {
        public int StudyId { get; set; }
        public Guid UserId { get; set; }
        public int StudyTypeId {  get; set; }
        public string Description { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }

        public Resume resume { get; set; }
        public StudyType studyType { get; set; }

    }
}
