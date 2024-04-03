using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TracNghiemOnline.IRepository;
using TracNghiemOnline.Models;

namespace TracNghiemOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDeThiRepository _deThiRepository;

        public HomeController( IDeThiRepository deThiRepository) 
        {
            _deThiRepository = deThiRepository;
           
        }
    

        //public HomeController(ILogger<HomeController> logger)
        //{
         
        //}

        public async Task<IActionResult> Index()
        {
            var dethi = await _deThiRepository.GetDethisAsync();

            return View(dethi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
