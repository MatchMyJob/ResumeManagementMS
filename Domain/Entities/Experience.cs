using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public Guid UserId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string jobDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Resume resume {  get; set; }
    }
}
