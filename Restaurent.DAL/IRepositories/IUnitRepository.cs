using Restaurant.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.DAL.IRepositories
{
    public interface IUnitRepository : IRepository<Unit>
    {
        Task<Unit> GetByNameAsync(string unitName);
    }
}