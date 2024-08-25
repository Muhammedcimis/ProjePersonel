using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonelProjesiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Configuration
{
    public class PersonelConfiguration : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Soyadi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cinsiyet).IsRequired();
            builder.Property(x => x.Sehir).IsRequired();
            builder.Property(x => x.Departman).IsRequired();
            builder.Property(x => x.DogumTarihi).IsRequired();
        }
    }
}
