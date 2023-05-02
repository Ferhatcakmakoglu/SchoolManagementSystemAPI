using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class StudentsWithSchoolRepository : GenericRepository<Student>, IStudentsWithSchoolRepository
    {
        public StudentsWithSchoolRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Student>> GetStudentsWithSchool()
        {
            //return _dbContext.Products.Include(x => x.Category).ToListAsync();
            return _dbContext.Students.Include(x => x.School).ToListAsync();
        }
    }
}
