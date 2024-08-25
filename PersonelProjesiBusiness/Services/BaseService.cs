using PersonelProjesiBusiness.Core;
using PersonelProjesiDataAccess.Core;
using PersonelProjesiDataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiBusiness.Services
{
    public class BaseService<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public BaseService(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
