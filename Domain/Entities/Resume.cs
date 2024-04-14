using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resume
    {
       public required int ResumeId { get; set; }
       public required Guid UserId { get; set; }
       public required string Description { get; set; }
       public int MinimunSalary { get; set; }
       public string? Image {get; set;}
    }
}