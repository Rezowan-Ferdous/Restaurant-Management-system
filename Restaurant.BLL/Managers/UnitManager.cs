using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.BLL.IManagers;
using Restaurant.ENTITY;
using Restaurent.DAL.IRepositories;


namespace Restaurant.BLL.Managers
{
    public class UnitManager : Manager<Unit>, IUnitManager
    {
        private readonly IUnitRepository _unitRepository;
        public UnitManager(IUnitRepository Repository) :base (Repository)
        {
            _unitRepository = Repository;
        }
        public override async Task<bool> AddAsync(Unit entity)
        {
            Unit unit = await _unitRepository.GetByNameAsync(entity.UnitName);
            if (unit != null)
            {
                return false;
            }
            return await base.AddAsync(entity);
        }

        public async Task<Unit> GetByNameAsync(string unitName)
        {
            return await _unitRepository.GetByNameAsync(unitName);
        }

    }
}
