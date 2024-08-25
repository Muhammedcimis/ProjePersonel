using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiBusiness.Core
{
    public interface IService<T> where T : class
    {
        //Servis Katmanımız için geçerli olam core -business katmanında oluşturduk ?
        //service katmanı Bu katman business logic kodlarımın olduğu yerdir. Datayı aldıktan sonra datayla ilgili ekstra işlemlerim burada olacak
        //Service katmanı için burası kullanılacak

        //buradaki asıl amaç repository katmanından almış olduğumuz dayayı service katmanında mapping alidations, exceptions gibi veya başka şeylere dönüştürme gibi işlevleri kullanmak için
        //örnek : mesela Personel için ayrı bir repostory oluşturudğumuzda daah sonra IService ile IGenericRepository un dönüş tipleri farklılaşmaya başlayacaktır

        Task<List<T>> GetAllAsync(); // Tüm kayıtları getirir.

        Task<T> GetById(int id);  // Id'ye göre kayıt getirir.

        Task AddAsync(T entity); // Yeni bir kayıt ekler.

        Task UpdateAsync(T entity); // Var olan bir kaydı günceller.

        Task DeleteAsync(int id);  // Id'ye göre kaydı siler.
    }
}
