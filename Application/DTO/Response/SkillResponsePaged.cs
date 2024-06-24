using Application.DTO.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Response
{
    public class SkillResponsePaged
    {
        public MetaData metaData {  get; set; }
        public SkillResponse data { get; set; }
    }
}
