using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Data;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;

namespace TracNghiemOnline.EFReponsitory
{
    public class EFCauhoiRepository : ICauhoiRepository
    {
        private readonly ApplicationDbContext _context;

        public EFCauhoiRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cauhoi>> GetAllAsync(int id)
        {
            return await _context.Cauhois.Include(p=>p.DapAns).Include(p=>p.Dethi).Where(p=>p.DethiId==id).ToListAsync();
        }

        public async Task<int> CheckResult(int DapAnId, int id) {
            var KQ = await _context.Cauhois.FirstOrDefaultAsync(p => p.Id == id);
            
            if (KQ.DapAnId ==DapAnId) return 1;
            return -1;   
        }

       

    }
}
