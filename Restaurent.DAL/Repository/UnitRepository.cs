using Microsoft.EntityFrameworkCore;
using Restaurant.DB.Data;
using Restaurant.ENTITY;
using Restaurent.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.DAL.Repository
{
    public class UnitRepository : IUnitRepository
    {
        private readonly ApplicationDbContext _context;
        public UnitRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(Unit model)
        {
            await _context.AddAsync(model);
            bool isSaved = await _context.SaveChangesAsync() > 0;
            return isSaved;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Unit unit = await _context.Units.FirstOrDefaultAsync(u => u.Id == id);
            if (unit == null)
            {
                return false;
            }
            _context.Units.Remove(unit);
            bool isDeleted = await _context.SaveChangesAsync()>0;
            return isDeleted;
        }

        public async Task<ICollection<Unit>> GetAllAsync()
        {
            return await _context.Units.ToListAsync();
        }

        public async Task<Unit?> GetByIdAsync(int id)
        {
            var unit = await _context.Units.FirstOrDefaultAsync(u => u.Id == id);
            if (unit != null)
            {
                return unit;
            }
            return null;
        }

        public async Task<bool> UpdateAsync(Unit unit)
        {
            var exitingUnit = await _context.Units.FindAsync(unit.Id);
            if (exitingUnit != null)
            {
                _context.Units.Update(unit);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
