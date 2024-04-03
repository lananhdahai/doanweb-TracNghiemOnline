using TracNghiemOnline.Models;

namespace TracNghiemOnline.Repository
{
    public interface ICauhoiRepository
    {
        Task<IEnumerable<Cauhoi>> GetAllAsync(int id);
        Task<int> CheckResult(int IdDapAn, int id);


    }
}
