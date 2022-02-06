using Restaurant.BLL.IManager;
using Restaurant.ENTITY;
using Restaurent.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Manager
{
    public class UnitManager : IUnitManager
    {
        private readonly IUnitRepository _unitRepository;
        public UnitManager(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<bool> AddAsync(Unit unit)
        {
            return await _unitRepository.AddAsync(unit);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _unitRepository.DeleteAsync(id);
        }

        public async Task<ICollection<Unit>> GetAllAsync()
        {
            return await _unitRepository.GetAllAsync();
        }

        public async Task<Unit> GetByIdAsync(int id)
        {
            return await _unitRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Unit unit)
        {
            return await _unitRepository.UpdateAsync(unit);
        }
    }
}
