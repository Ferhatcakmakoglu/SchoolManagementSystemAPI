using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class StudentDto : BaseDtoForPerson
    {
        public int ClassLevel { get; set; }
        public string ClassBranch { get; set; }
        public int SchoolId { get; set; }
    }
}
