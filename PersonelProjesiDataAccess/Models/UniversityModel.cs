using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Models
{
    public class UniversityModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string[] Domains { get; set; }
        public string[] WebPages { get; set; }
        public List<string> MezuniyetBilgisi { get; set; }
    }
}
