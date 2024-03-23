using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;

namespace TracNghiemOnline.EFReponsitory
{
    public class EFMonhocRepository : IMonhocRepository
    {
        private readonly TracNghiemOnlineContext _context;

        public EFMonhocRepository(TracNghiemOnlineContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Monhoc>> GetAllAsync()
        {
            return await _context.Monhocs.ToListAsync();
        }

        public async Task<Monhoc> GetByIdAsync(int id)
        {
            return await _context.Monhocs.FindAsync(id);
        }

        public async Task AddAsync(Monhoc monhoc)
        {
            _context.Monhocs.Add(monhoc);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Monhoc monhoc)
        {
            _context.Entry(monhoc).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var monhoc = await _context.Monhocs.FindAsync(id);
            _context.Monhocs.Remove(monhoc);
            await _context.SaveChangesAsync();
        }
    }
}
