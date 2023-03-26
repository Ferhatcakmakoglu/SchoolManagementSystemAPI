using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IStudentService : IService<Student>
    {
        //Apimiz donus tipi CustomResponse istedigi icin onu burda halledip gondericez
        Task<CustomResponseDto<List<StudentDto>>> GetStudents(); 
    }
}
