using PersonelProjesiDataAccess.Core;
using PersonelProjesiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Repository
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonelRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;  
        }

        public List<string> GetUniversities()
        {
            throw new NotImplementedException();
        }
    }
}
