using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;

namespace TracNghiemOnline.EFReponsitory
{
    public class EFLophocRepository : ILophocRepository
    {
        private readonly TracNghiemOnlineContext _context;

        public EFLophocRepository(TracNghiemOnlineContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Lophoc>> GetAllAsync()
        {
            return await _context.Lophocs.ToListAsync();
        }

        public async Task<Lophoc> GetByIdAsync(int id)
        {
            return await _context.Lophocs.FindAsync(id);
        }

        public async Task AddAsync(Lophoc lophoc)
        {
            _context.Lophocs.Add(lophoc);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Lophoc lophoc)
        {
            _context.Lophocs.Update(lophoc);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var lophoc = await _context.Lophocs.FindAsync(id);
            _context.Lophocs.Remove(lophoc);
            await _context.SaveChangesAsync();
        }
    }
}
