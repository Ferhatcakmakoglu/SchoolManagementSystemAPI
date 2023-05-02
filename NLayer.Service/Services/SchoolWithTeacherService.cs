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
    public class SchoolWithTeacherService : Service<School>, ISchoolWithTeacherService
    {
        private readonly ISchoolWithTeacherRepository _schoolWithTeacherRepository;
        private readonly IMapper _mapper;
        public SchoolWithTeacherService(IGenericRepository<School> repository, IUnitOfWork unitOfWork, ISchoolWithTeacherRepository schoolWithTeacherRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _schoolWithTeacherRepository = schoolWithTeacherRepository;
        }

        public async Task<CustomResponseDto<SchoolWithTeacherDto>> GetSchoolWithTeacher(int schoolId)
        {
            var schools = await _schoolWithTeacherRepository.GetSchoolWithTeacher(schoolId);
            var schoolsDto = _mapper.Map<SchoolWithTeacherDto>(schools);
            return CustomResponseDto<SchoolWithTeacherDto>.Succes(200, schoolsDto);
        }
    }
}
