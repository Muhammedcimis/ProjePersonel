using PersonelProjesiDataAccess.Core;
using PersonelProjesiDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _Context;
        public IPersonelRepository Personel { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _Context = context;
            Personel = new PersonelRepository(_Context);
        }

        public void Commit()
        {
            _Context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
