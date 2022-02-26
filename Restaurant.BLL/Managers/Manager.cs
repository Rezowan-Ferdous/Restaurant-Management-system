using Restaurant.BLL.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurent.DAL.IRepositories;


namespace Restaurant.BLL.Managers
{
    public class Manager<T> : IManager<T> where T : class
    {
       public readonly IRepository<T> _repository;

        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
            bool isAdded = await _repository.AddAsync(entity);
            if (isAdded)
            {
                return true;
            }
            return false;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return result;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<bool> RemoveAsync(int id)
        {
            return await _repository.RemoveAsync(id);
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            bool isUpdated = await _repository.AddAsync(entity);
            if (isUpdated)
            {
                return true;
            }
            return false;
        }
    }

}
