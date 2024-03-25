using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TracNghiemOnline.Models
{
    public class EFMucdokhoRepository : IMucdokhoRepository
    {
        private readonly TracNghiemOnlineContext _context;

        public EFMucdokhoRepository(TracNghiemOnlineContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mucdokho>> GetAllMucdokho()
        {
            return await _context.Mucdokhos.ToListAsync();
        }

        public async Task<Mucdokho> GetMucdokhoById(int id)
        {
            return await _context.Mucdokhos.FindAsync(id);
        }

        public async Task CreateMucdokho(Mucdokho mucdokho)
        {
            _context.Add(mucdokho);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMucdokho(Mucdokho mucdokho)
        {
            _context.Update(mucdokho);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMucdokho(int id)
        {
            var mucdokhoToDelete = await _context.Mucdokhos.FindAsync(id);
            if (mucdokhoToDelete != null)
            {
                _context.Mucdokhos.Remove(mucdokhoToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
