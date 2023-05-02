using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class SchoolWithTeacherDto : SchoolDto
    {
        //public TeacherDto Teacher { get; set; }
        public List<TeacherDto> Teachers { get; set; }
    }
}
