using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;

namespace TracNghiemOnline.Controllers
{
    public class MonhocController : Controller
    {
        private readonly IMonhocRepository _monhocRepository;
        private readonly ILophocRepository _lophocRepository;

        public MonhocController(IMonhocRepository monhocRepository, ILophocRepository lophocRepository)
        {
            _monhocRepository = monhocRepository;
            _lophocRepository = lophocRepository;
        }

        // Hiển thị danh sách môn học
        public async Task<IActionResult> Index()
        {
            var monhocs = await _monhocRepository.GetAllAsync();
            return View(monhocs);
        }

        // Hiển thị form thêm môn học mới
        public async Task<IActionResult> Add()
        {
            var lophocs = await _lophocRepository.GetAllAsync();
            ViewBag.Lophocs = new SelectList(lophocs, "Idlop", "Tenlop");
            return View();
        }

        // Xử lý thêm môn học mới
        [HttpPost]
        public async Task<IActionResult> Add(Monhoc monhoc)
        {
            if (ModelState.IsValid)
            {
                await _monhocRepository.AddAsync(monhoc);
                return RedirectToAction(nameof(Index));
            }
            // Nếu ModelState không hợp lệ, hiển thị form với dữ liệu đã nhập
            var lophocs = await _lophocRepository.GetAllAsync();
            ViewBag.Lophocs = new SelectList(lophocs, "Idlop", "Tenlop");
            return View(monhoc);
        }

        // Hiển thị thông tin chi tiết môn học
        public async Task<IActionResult> Details(int id)
        {
            var monhoc = await _monhocRepository.GetByIdAsync(id);
            if (monhoc == null)
            {
                return NotFound();
            }
            return View(monhoc);
        }

        // Hiển thị form cập nhật môn học
        public async Task<IActionResult> Edit(int id)
        {
            var monhoc = await _monhocRepository.GetByIdAsync(id);
            if (monhoc == null)
            {
                return NotFound();
            }
            var lophocs = await _lophocRepository.GetAllAsync();
            ViewBag.Lophocs = new SelectList(lophocs, "Idlop", "Tenlop", monhoc.Idlop);
            return View(monhoc);
        }

        // Xử lý cập nhật môn học
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Monhoc monhoc)
        {
            if (id != monhoc.Idmon)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _monhocRepository.UpdateAsync(monhoc);
                return RedirectToAction(nameof(Index));
            }
            return View(monhoc);
        }

        // Hiển thị form xác nhận xóa môn học
        public async Task<IActionResult> Delete(int id)
        {
            var monhoc = await _monhocRepository.GetByIdAsync(id);
            if (monhoc == null)
            {
                return NotFound();
            }
            return View(monhoc);
        }

        // Xử lý xóa môn học
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _monhocRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
