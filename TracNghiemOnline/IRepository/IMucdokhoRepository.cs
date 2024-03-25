using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TracNghiemOnline.Models
{
    public interface IMucdokhoRepository
    {
        Task<IEnumerable<Mucdokho>> GetAllMucdokho();
        Task<Mucdokho> GetMucdokhoById(int id);
        Task CreateMucdokho(Mucdokho mucdokho);
        Task UpdateMucdokho(Mucdokho mucdokho);
        Task DeleteMucdokho(int id);
    }
}
