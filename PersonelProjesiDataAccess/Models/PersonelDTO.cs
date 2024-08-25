using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Models
{
    public class PersonelDTO
    {
        [Required, MaxLength(50)]
        public string? Adi { get; set; }

        [Required, MaxLength(50)]
        public string? Soyadi { get; set; }

        [Required]
        public string? Cinsiyet { get; set; }
        public bool IsZimmet { get; set; }
        public string? Mezuniyet { get; set; }
        public List<string>? MezuniyetBilgisi { get; set; }

        [Required]
        public string? Sehir { get; set; }
        [Required]
        public string? Departman { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        public int Maas { get; set; }
    }
}
