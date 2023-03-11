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
    internal class SchoolSeed : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(new School
            {
                Id = 1,
                Name = "Cankiri Karatekin Universitesi",
                SchoolType = "Universite",
                CreatedTime = DateTime.Now,
                DateOfConstruction = 2007,
                NumberOfStudent = 17000,
                NumberOfTeacher = 250,
                Adress = "Uluyazi Cankiri/Turkiye",
                MailAdress = "caku@caku.com",
                PhoneNumber = "1234567890"
            },
            new School
            {
                Id = 2,
                Name = "Maltepe Universitesi",
                SchoolType = "Universitesi",
                CreatedTime = DateTime.Now,
                DateOfConstruction = 2010,
                NumberOfStudent = 7000,
                NumberOfTeacher = 100,
                Adress = "Maltepe/Istanbul",
                MailAdress = "maltepe@info.com",
                PhoneNumber = "1234567890"

            });
        }
    }
}
