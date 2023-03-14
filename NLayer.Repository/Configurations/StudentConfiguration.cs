﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            /*
                BAZI KOMUTLARIN ANLAMLARI: 
                    HasKey(x => x.Id) => id min o Id oldugunu belirtir
                    UseIdentityColumn() => default olarak 1er 1er artması anlamında, istersek parametre olarak deger verebiliriz
                    IsRequired()        => Bu alan bos olmasın (zorunlu olsun)
                    HasMaxLength(20)    => Max 20 karakter olsun
                    ToTable()        => Tablomuzun ismini belirler. Vermezsek eger AppDbContext deki ilgili fonk ismini kullanır
             */
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);
            builder.Property(x => x.DateOfBirth).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Gender).IsRequired().HasMaxLength(1);
            builder.Property(x => x.ClassLevel).IsRequired();
            builder.Property(x => x.ClassBranch).IsRequired();
            builder.Property(x => x.ParentName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.ParentSurname).IsRequired().HasMaxLength(20);
            builder.Property(x => x.ParentPhoneNumber).IsRequired().HasMaxLength(11);
            builder.ToTable("Students");
        }
    }
}
