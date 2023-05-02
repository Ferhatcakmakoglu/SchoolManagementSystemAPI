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
    public class SchoolWithTeacherRepository : GenericRepository<School>, ISchoolWithTeacherRepository
    {
        public SchoolWithTeacherRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<School> GetSchoolWithTeacher(int schoolId)
        {
            //return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
            return await _dbContext.Schools.Include(x => x.Teachers).Where(x => x.Id == schoolId).SingleOrDefaultAsync();
        }
    }
}
