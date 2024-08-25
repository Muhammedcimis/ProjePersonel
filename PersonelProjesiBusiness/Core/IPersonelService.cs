using PersonelProjesiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiBusiness.Core
{
    public interface IPersonelService : IService<Personel>
    {
        public Task<List<string>> GetUniversitiesAsync();
    }
}
