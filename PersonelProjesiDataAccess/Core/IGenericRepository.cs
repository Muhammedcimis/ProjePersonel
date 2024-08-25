using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Core
{
    public interface IGenericRepository<T> where T : class
    {
        //Veritabanında yapılan tüm temel sorgular buradaki T diye bir clas parametre alacak ancak ne alacağını gönderirken belirleyeceğiz o yüzden de t adında bir parametre oluşturduk

        Task<List<T>> GetAllAsync(); // Tüm kayıtları getirir.
        //IQueryable<T> GetAll(); // Tüm kayıtları getirir.
        Task<T> GetByIdAsync(int id); // Belirtilen Id'ye göre kayıt getirir.
        Task<T> AddAsync(T entity);// Yeni bir kayıt ekler.
        Task<T> UpdateAsync(T entity); // Var olan bir kaydı günceller. idyi alaacak
        Task<T> DeleteAsync(int id); // Belirtilen Id'ye göre kaydı siler.
    }
}
