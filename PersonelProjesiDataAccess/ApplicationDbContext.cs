using Microsoft.EntityFrameworkCore;
using PersonelProjesiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Personel> Personels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //assembly oalrak belirttik. kendşisi ottomatik configuratiıon dosyalarını buluyor
                                                                                           //veritabanına başlangıç verileri gönderiyoruz
            modelBuilder.Entity<Personel>().HasData(
                new Personel { Id = 1, Adi = "Ahmet", Soyadi = "Yılmaz", Cinsiyet = "Erkek", IsZimmet = true, Mezuniyet = "İstanbul Üniversitesi", Sehir = "İstanbul", Departman = "Yazılım", DogumTarihi = new DateTime(1990, 5, 3), Maas = 50000 },
                new Personel { Id = 2, Adi = "Ayşe", Soyadi = "Demir", Cinsiyet = "Kadın", IsZimmet = true, Mezuniyet = "Ankara Üniversitesi", Sehir = "Ankara", Departman = "Pazarlama", DogumTarihi = new DateTime(1999, 6, 8), Maas = 45000 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
