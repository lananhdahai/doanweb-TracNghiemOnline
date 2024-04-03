using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Data;
using TracNghiemOnline.IRepository;
using TracNghiemOnline.Models;

namespace TracNghiemOnline.EFReponsitory
{
    public class EFDeThiReponsitory : IDeThiRepository
    {
        private readonly ApplicationDbContext _context;

        public EFDeThiReponsitory(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Dethi>> GetDethisAsync()
        {
            return  await _context.Dethis.Include(p => p.Monhoc).Include(p => p.Lophoc).ToListAsync();
        }

        public async Task<Dethi> GetByIdAsync(int id)
        {
            return await _context.Dethis.Include(p => p.Monhoc).Include(p => p.Lophoc).FirstOrDefaultAsync(p => p.Id == id);
        }


        public async Task<IEnumerable<Cauhoi>> GetAllCauHoiById(int id)
        {
            var cauhoi = await _context.Cauhois.Include(p => p.DapAns).Where(p => p.DethiId == id).ToListAsync();
            return cauhoi;
        }
    }
}
