using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TracNghiemOnline.Data;

namespace TracNghiemOnline.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public  IActionResult Index()
        {
            return View();
        }
    }
}
