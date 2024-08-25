using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiBusiness.Core
{
    public interface IService<T> where T : class
    {        
        Task<List<T>> GetAllAsync(); // Tüm kayıtları getirir.

        Task<T> GetById(int id);  // Id'ye göre kayıt getirir.

        Task AddAsync(T entity); // Yeni bir kayıt ekler.

        Task UpdateAsync(T entity); // Var olan bir kaydı günceller.

        Task DeleteAsync(int id);  // Id'ye göre kaydı siler.
    }
}
