using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class TeacherSeed : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(new Teacher
            {
                Id = 1,
                Name = "Selim",
                Surname = "Buyrukoglu",
                PhoneNumber = "1234567890",
                DateOfBirth = "20/07/1989",
                Age = 34,
                Gender = "Erkek",
                CreatedTime = DateTime.Now,
                Branch = "Computer Since",
                BranchType = "Lecturer",
                SchoolId = 1
            },
            new Teacher
            {
                Id = 1,
                Name = "Kazim",
                Surname = "Nalburoglu",
                PhoneNumber = "1478523690",
                DateOfBirth = "10/11/1989",
                Age = 44,
                Gender = "Erkek",
                CreatedTime = DateTime.Now,
                Branch = "Network Since",
                BranchType = "Professor Lecturer",
                SchoolId = 2
            });
        }
    }
}
