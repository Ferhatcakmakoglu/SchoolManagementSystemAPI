using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface ISchoolWithTeacherService : IService<School>
    {
        //public Task<CustomResponseDto<List<SchoolWithTeacherDto>>> GetSchoolWithTeacher(int schoolId);
        public Task<CustomResponseDto<SchoolWithTeacherDto>> GetSchoolWithTeacher(int schoolId);
        //public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
