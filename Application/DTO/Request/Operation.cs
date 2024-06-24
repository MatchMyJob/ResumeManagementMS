using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Request
{
    public class Operation
    {
        public OperationType operationType { get; set; }
        public string path { get; set; }
        public string op {  get; set; }
        public string from { get; set; }
        public string value { get; set; }
    }
}
