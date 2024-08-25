using PersonelProjesiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Core
{
    public interface IPersonelRepository : IGenericRepository<Personel>
    {
        public List<string> GetUniversities();
    }
}
