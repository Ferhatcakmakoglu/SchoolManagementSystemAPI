using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(new Student 
            {
                Id = 1,
                Name = "Ferhat",
                Surname = "Cakmakoglu",
                PhoneNumber = "1234567890",
                DateOfBirth = "17/01/2002",
                Age = 21,
                Gender = "E",
                CreatedTime = DateTime.Now,
                ClassLevel = 2,
                ClassBranch = "Computer Engineer",
                ParentName = "Ali",
                ParentSurname = "Cakmakoglu",
                ParentPhoneNumber = "1234567890",
                SchoolId = 1
            },
            new Student
            {
                Id = 2,
                Name = "Sakir",
                Surname = "Ayitki",
                PhoneNumber = "9876541230",
                DateOfBirth = "20/10/2002",
                Age = 20,
                Gender = "E",
                CreatedTime = DateTime.Now,
                ClassLevel = 2,
                ClassBranch = "Computer Engineer",
                ParentName = "Bilmiyom",
                ParentSurname = "Ayitki",
                ParentPhoneNumber = "1234567890",
                SchoolId = 2
            });
        }
    }
}
