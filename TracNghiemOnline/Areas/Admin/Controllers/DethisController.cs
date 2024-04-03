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
    [Authorize(Roles = "Admin")]
    public class DethisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DethisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Dethis
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Dethis.Include(d => d.Lophoc).Include(d => d.Monhoc);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Dethis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dethi = await _context.Dethis
                .Include(d => d.Lophoc)
                .Include(d => d.Monhoc)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dethi == null)
            {
                return NotFound();
            }

            return View(dethi);
        }

        // GET: Admin/Dethis/Create
        public IActionResult Create()
        {
            ViewData["LophocId"] = new SelectList(_context.Lophocs, "Id", "Tenlop");
            ViewData["MonhocId"] = new SelectList(_context.Monhocs, "Id", "Tenmon");
            return View();
        }

        // POST: Admin/Dethis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Gio,Phut,SlCau,NgayTao,Noidung,LophocId,MonhocId")] Dethi dethi,IFormFile ImageUrl)
        {
            if (ModelState.IsValid)
            {
                dethi.ImageUrl = await SaveImage(ImageUrl);
                _context.Add(dethi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LophocId"] = new SelectList(_context.Lophocs, "Id", "Tenlop", dethi.LophocId);
            ViewData["MonhocId"] = new SelectList(_context.Monhocs, "Id", "Tenmon", dethi.MonhocId);
            return View(dethi);
        }

      

        // GET: Admin/Dethis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dethi = await _context.Dethis.FindAsync(id);
            if (dethi == null)
            {
                return NotFound();
            }
            ViewData["LophocId"] = new SelectList(_context.Lophocs, "Id", "Tenlop", dethi.LophocId);
            ViewData["MonhocId"] = new SelectList(_context.Monhocs, "Id", "Tenmon", dethi.MonhocId);
            return View(dethi);
        }

        // POST: Admin/Dethis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Gio,Phut,SlCau,NgayTao,Noidung,LophocId,MonhocId")] Dethi dethi)
        {
            if (id != dethi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dethi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DethiExists(dethi.Id))
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
            ViewData["LophocId"] = new SelectList(_context.Lophocs, "Id", "Tenlop", dethi.LophocId);
            ViewData["MonhocId"] = new SelectList(_context.Monhocs, "Id", "Tenmon", dethi.MonhocId);
            return View(dethi);
        }

        // GET: Admin/Dethis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dethi = await _context.Dethis
                .Include(d => d.Lophoc)
                .Include(d => d.Monhoc)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dethi == null)
            {
                return NotFound();
            }

            return View(dethi);
        }

        // POST: Admin/Dethis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dethi = await _context.Dethis.FindAsync(id);
            if (dethi != null)
            {
                _context.Dethis.Remove(dethi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DethiExists(int id)
        {
            return _context.Dethis.Any(e => e.Id == id);
        }

        private async Task<string> SaveImage(IFormFile image)
        {
            var savePath = Path.Combine("wwwroot/Image", image.FileName);
            using (var fileStream = new FileStream(savePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }
            return "/Image/" + image.FileName;
        }
    }
}
