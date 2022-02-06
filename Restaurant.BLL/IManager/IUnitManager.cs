using Restaurant.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.IManager
{
    public interface IUnitManager
    {
        Task<bool> AddAsync(Unit unit);
        Task<bool> UpdateAsync(Unit unit);
        Task<Unit> GetByIdAsync(int id);
        Task<ICollection<Unit>> GetAllAsync();
        Task<bool> DeleteAsync(int id);
    }
}
