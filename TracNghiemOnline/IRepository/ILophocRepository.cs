using TracNghiemOnline.Models;

namespace TracNghiemOnline.Repository
{
    public interface ILophocRepository
    {
        Task<IEnumerable<Lophoc>> GetAllAsync();
        Task<Lophoc> GetByIdAsync(int id);
        Task AddAsync(Lophoc lophoc);
        Task UpdateAsync(Lophoc lophoc);
        Task DeleteAsync(int id);
    }
}
