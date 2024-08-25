using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDomain.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Cinsiyet { get; set; }
        public bool IsZimmet { get; set; }
        public string? Mezuniyet { get; set; }
        public string? Sehir { get; set; }
        public string? Departman { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Maas { get; set; }
    }
}
