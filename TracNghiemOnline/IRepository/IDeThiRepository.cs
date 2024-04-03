using TracNghiemOnline.Models;

namespace TracNghiemOnline.IRepository
{
    public interface IDeThiRepository
    {
        Task<IEnumerable<Dethi>> GetDethisAsync();
        Task<Dethi> GetByIdAsync(int id);

      
     
    }
}
