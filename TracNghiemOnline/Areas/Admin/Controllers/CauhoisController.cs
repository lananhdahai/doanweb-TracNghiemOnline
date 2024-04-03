using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Data;
using TracNghiemOnline.Models;

namespace TracNghiemOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CauhoisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CauhoisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Cauhois
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cauhois.Include(c => c.DapAns).Include(c => c.Dethi);
                return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Cauhois/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauhoi = await _context.Cauhois
                .Include(c => c.DapAns)
                .Include(c => c.Dethi)               
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cauhoi == null)
            {
                return NotFound();
            }

            return View(cauhoi);
        }

        // GET: Admin/Cauhois/Create
        public IActionResult Create(int ? Id)
        {
            ViewData["DapAnId"] = new SelectList(_context.DapAns, "ID", "Name");
            ViewData["DethiId"] = new SelectList(_context.Dethis, "Id", "Id");
           
            return View();
        }

        // POST: Admin/Cauhois/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int Id, [Bind("Noidung,DaA,DaB,DaC,DaD,ImageUrl,DapAnId")] Cauhoi cauhoi)
        {
            if (ModelState.IsValid)
            {
                cauhoi.DethiId = Id;
             
                _context.Add(cauhoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DapAnId"] = new SelectList(_context.DapAns, "ID", "Name", cauhoi.DapAnId);
            ViewData["DethiId"] = new SelectList(_context.Dethis, "Id", "Id", cauhoi.DethiId);
           
            return View(cauhoi);
        }

        // GET: Admin/Cauhois/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauhoi = await _context.Cauhois.FindAsync(id);
            if (cauhoi == null)
            {
                return NotFound();
            }
            ViewData["DapAnId"] = new SelectList(_context.DapAns, "ID", "Name", cauhoi.DapAnId);
            ViewData["DethiId"] = new SelectList(_context.Dethis, "Id", "Id", cauhoi.DethiId);
           
            return View(cauhoi);
        }

        // POST: Admin/Cauhois/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Noidung,DaA,DaB,DaC,DaD,Khac,Da,ImageUrl,DethiId,KetquaId,DapAnId")] Cauhoi cauhoi)
        {
            if (id != cauhoi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauhoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauhoiExists(cauhoi.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DapAnId"] = new SelectList(_context.DapAns, "ID", "Name", cauhoi.DapAnId);
            ViewData["DethiId"] = new SelectList(_context.Dethis, "Id", "Id", cauhoi.DethiId);
            
            return View(cauhoi);
        }

        // GET: Admin/Cauhois/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauhoi = await _context.Cauhois
                .Include(c => c.DapAns)
                .Include(c => c.Dethi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cauhoi == null)
            {
                return NotFound();
            }

            return View(cauhoi);
        }

        // POST: Admin/Cauhois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauhoi = await _context.Cauhois.FindAsync(id);
            if (cauhoi != null)
            {
                _context.Cauhois.Remove(cauhoi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauhoiExists(int id)
        {
            return _context.Cauhois.Any(e => e.Id == id);
        }
    }
}
