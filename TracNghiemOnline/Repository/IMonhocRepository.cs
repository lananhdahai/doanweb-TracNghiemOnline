using TracNghiemOnline.Models;

namespace TracNghiemOnline.Repository
{
    public interface IMonhocRepository
    {
        Task<IEnumerable<Monhoc>> GetAllAsync();
        Task<Monhoc> GetByIdAsync(int id);
        Task AddAsync(Monhoc monhoc);
        Task UpdateAsync(Monhoc monhoc);
        Task DeleteAsync(int id);
    }
}
