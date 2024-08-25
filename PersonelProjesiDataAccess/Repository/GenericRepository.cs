using Microsoft.EntityFrameworkCore;
using PersonelProjesiDataAccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiDataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //burada generic olarak database işlemlerini yapıyoruz

        protected readonly ApplicationDbContext _dbcontext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
            _dbSet = _dbcontext.Set<T>(); // T türündeki DbSet'i alır.
        }

        public async Task<T> AddAsync(T entity)
        {
            //await _dbSet.AddAsync(entity);
            _dbSet.Add(entity);
            //await _dbcontext.SaveChangesAsync(); //unitofwork olmadan db kayıt denemesi
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
            //await _dbcontext.SaveChangesAsync(); //unitofwork olmadan db kayıt denemesi

            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            //await _dbcontext.SaveChangesAsync(); //unitofwork olmadan db kayıt denemesi
            return entity;
        }
    }
}
