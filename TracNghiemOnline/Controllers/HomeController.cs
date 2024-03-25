using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Models;

public class HomeController : Controller
{
    private readonly TracNghiemOnlineContext _context;

    public HomeController(TracNghiemOnlineContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        // Lấy danh sách lớp học và các môn học tương ứng
        var lops = await _context.Lophocs.Include(l => l.Monhocs).ToListAsync();
        ViewBag.Lops = lops;

        return View();
    }
}
