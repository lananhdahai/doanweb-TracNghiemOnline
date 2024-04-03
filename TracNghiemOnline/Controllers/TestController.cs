using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.WebSockets;
using TracNghiemOnline.IRepository;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;


namespace TracNghiemOnline.Controllers
{
    public class TestController : Controller
    {

        private readonly ICauhoiRepository _ICauhoiRepository;
        private readonly IDeThiRepository _IDeThiRepository;

        public TestController(IDeThiRepository IdeThiRepository, ICauhoiRepository iCauhoiRepository)
        {
            _IDeThiRepository = IdeThiRepository;
            _ICauhoiRepository = iCauhoiRepository; 
        }
        public async Task<IActionResult> Test(int id)
        {

            var Cauhois = await _ICauhoiRepository.GetAllAsync(id);
            ViewBag.DeThi = await _IDeThiRepository.GetByIdAsync(id);
         
            return View(Cauhois);
        }

        public async Task<IActionResult> TestCheck(int id,string Data)
        {
         var DeThi = await _IDeThiRepository.GetByIdAsync(id);
            int Grade = 0;
            var Datas = Data.Split(";");
            for(var  i = 0; i < Datas.Length-1; i++)
            {
                var Result = Datas[i].Split(",");
                int Kq = await _ICauhoiRepository.CheckResult(Int32.Parse(Result[0])+1, Int32.Parse( Result[1]));
                if (Kq == 1 )
                {
                    Grade++;
                }
            }

      
            ViewBag.Grade = Grade;
           

            return View(DeThi);
        }
    }
}
