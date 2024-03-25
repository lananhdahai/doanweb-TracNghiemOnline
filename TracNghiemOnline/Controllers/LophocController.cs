using Microsoft.AspNetCore.Mvc;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;

namespace TracNghiemOnline.Controllers
{
    public class LophocController : Controller
    {

        private readonly ILophocRepository _lophocRepository;

        public LophocController(ILophocRepository lophocRepository)
        {
            _lophocRepository = lophocRepository;
        }

        // Hiển thị danh sách lớp học
        public async Task<IActionResult> Index()
        {
            var lophocs = await _lophocRepository.GetAllAsync();
            ViewBag.Lophocs = lophocs; // Gán danh sách các lớp học cho ViewBag
            return View(lophocs);
        }

        // Hiển thị form thêm lớp học mới
        public IActionResult Add()
        {
            return View();
        }

        // Xử lý thêm lớp học mới
        [HttpPost]
        public async Task<IActionResult> Add(Lophoc lophoc)
        {
            if (ModelState.IsValid)
            {
                await _lophocRepository.AddAsync(lophoc);
                return RedirectToAction(nameof(Index));
            }
            // Nếu ModelState không hợp lệ, hiển thị form với dữ liệu đã nhập
            return View(lophoc);
        }

        // Hiển thị thông tin chi tiết lớp học
        public async Task<IActionResult> Details(int id)
        {
            var lophoc = await _lophocRepository.GetByIdAsync(id);
            if (lophoc == null)
            {
                return NotFound();
            }
            return View(lophoc);
        }

        // Hiển thị form cập nhật lớp học
        public async Task<IActionResult> Edit(int id)
        {
            var lophoc = await _lophocRepository.GetByIdAsync(id);
            if (lophoc == null)
            {
                return NotFound();
            }
            return View(lophoc);
        }

        // Xử lý cập nhật lớp học
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Lophoc lophoc)
        {
            if (id != lophoc.Idlop)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _lophocRepository.UpdateAsync(lophoc);
                return RedirectToAction(nameof(Index));
            }
            return View(lophoc);
        }

        // Hiển thị form xác nhận xóa lớp học
        public async Task<IActionResult> Delete(int id)
        {
            var lophoc = await _lophocRepository.GetByIdAsync(id);
            if (lophoc == null)
            {
                return NotFound();
            }
            return View(lophoc);
        }

        // Xử lý xóa lớp học
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            await _lophocRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
