using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Student,StudentDto>().ReverseMap();
            CreateMap<Teacher,TeacherDto>().ReverseMap();
            CreateMap<School,SchoolDto>().ReverseMap();
            CreateMap<Student, StudentWithSchoolDto>();
            CreateMap<School,SchoolWithTeacherDto>();
        }
    }
}
