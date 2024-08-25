using PersonelProjesiDataAccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //burası savechanges methodu için kullanılacak
        IPersonelRepository Personel { get; }

        Task CommitAsync();

        void Commit();
    }
}
