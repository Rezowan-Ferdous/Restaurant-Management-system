using Microsoft.EntityFrameworkCore;
using Restaurant.DB.Data;
using Restaurant.ENTITY;
using Restaurent.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.DAL.Repositories
{
    public class UnitRepository : Repository<Unit>, IUnitRepository
    {
        public UnitRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override async Task<List<Unit>> GetAllAsync()
        {
            return await _context.Units.ToListAsync();
        }
        public override async Task<Unit> GetByIdAsync(int id)
        {
            return await _context.Units.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<Unit> GetByNameAsync(string UnitName)
        {
            return await _context.Units.FirstOrDefaultAsync(b => b.UnitName == UnitName);
        }
    }
}

