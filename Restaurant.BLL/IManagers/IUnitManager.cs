using Restaurant.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.IManagers
{
    public interface IUnitManager : IManager<Unit>
    {
        Task<Unit> GetByNameAsync(string unitName);
    }
}
