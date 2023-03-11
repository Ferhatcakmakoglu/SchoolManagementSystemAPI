using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
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
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.SchoolType).IsRequired();
            builder.Property(x => x.DateOfConstruction).IsRequired();
            builder.Property(x => x.NumberOfStudent).IsRequired();
            builder.Property(x => x.NumberOfTeacher).IsRequired();
            builder.Property(x => x.Adress).IsRequired();
            builder.Property(x => x.MailAdress).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(11);

            builder.ToTable("Schools");
        }
    }
}
