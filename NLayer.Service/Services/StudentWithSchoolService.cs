using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class StudentWithSchoolService : Service<Student>, IStudentsWithSchoolService
    {
        private readonly IStudentsWithSchoolRepository _studentsWithSchoolRepository;
        private readonly IMapper _mapper;

        public StudentWithSchoolService(IGenericRepository<Student> repository, IUnitOfWork unitOfWork, IStudentsWithSchoolRepository studentsWithSchoolRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _studentsWithSchoolRepository = studentsWithSchoolRepository;
        }

        public async Task<CustomResponseDto<List<StudentWithSchoolDto>>> GetStudentsWithSchool()
        {
            var students = await _studentsWithSchoolRepository.GetStudentsWithSchool();
            var studentsDto = _mapper.Map<List<StudentWithSchoolDto>>(students);
            return CustomResponseDto<List<StudentWithSchoolDto>>.Succes(200, studentsDto);
        }
    }
}
