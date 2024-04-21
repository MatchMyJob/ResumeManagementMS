using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class ResumeDTO
    {
        public required Guid UserId {get; set;}
        public required string Description {get; set;}
        public required int MinimunSalary {get; set;}
        public string? Image {get; set;}
    }
}