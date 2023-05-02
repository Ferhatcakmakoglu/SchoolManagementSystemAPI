using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class TeacherDto : BaseDtoForPerson
    {
        public string Branch { get; set; } //Math, Science
        public string BranchType { get; set; } //Teacher or Manager
        public int SchoolId { get; set; }
        
    }
}
