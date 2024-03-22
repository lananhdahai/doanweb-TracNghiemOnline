using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Models;

namespace TracNghiemOnline.Controllers
{
    public class MonhocController : Controller
    {
        private readonly TracNghiemOnlineContext _context;

        public MonhocController(TracNghiemOnlineContext context)
        {
            _context = context;
        }

        // GET: Monhoc
        public async Task<IActionResult> Index()
        {
            var tracNghiemOnlineContext = _context.Monhocs.Include(m => m.IdlopNavigation);
            return View(await tracNghiemOnlineContext.ToListAsync());
        }

        // GET: Monhoc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monhoc = await _context.Monhocs
                .Include(m => m.IdlopNavigation)
                .FirstOrDefaultAsync(m => m.Idmon == id);
            if (monhoc == null)
            {
                return NotFound();
            }

            return View(monhoc);
        }

        // GET: Monhoc/Create
        public IActionResult Create()
        {
            ViewData["Idlop"] = new SelectList(_context.Lophocs, "Idlop", "Idlop");
            return View();
        }

        // POST: Monhoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idmon,Tenmon,Mota,Idlop")] Monhoc monhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idlop"] = new SelectList(_context.Lophocs, "Idlop", "Idlop", monhoc.Idlop);
            return View(monhoc);
        }

        // GET: Monhoc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monhoc = await _context.Monhocs.FindAsync(id);
            if (monhoc == null)
            {
                return NotFound();
            }
            ViewData["Idlop"] = new SelectList(_context.Lophocs, "Idlop", "Idlop", monhoc.Idlop);
            return View(monhoc);
        }

        // POST: Monhoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idmon,Tenmon,Mota,Idlop")] Monhoc monhoc)
        {
            if (id != monhoc.Idmon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monhoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonhocExists(monhoc.Idmon))
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
            ViewData["Idlop"] = new SelectList(_context.Lophocs, "Idlop", "Idlop", monhoc.Idlop);
            return View(monhoc);
        }

        // GET: Monhoc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monhoc = await _context.Monhocs
                .Include(m => m.IdlopNavigation)
                .FirstOrDefaultAsync(m => m.Idmon == id);
            if (monhoc == null)
            {
                return NotFound();
            }

            return View(monhoc);
        }

        // POST: Monhoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monhoc = await _context.Monhocs.FindAsync(id);
            if (monhoc != null)
            {
                _context.Monhocs.Remove(monhoc);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonhocExists(int id)
        {
            return _context.Monhocs.Any(e => e.Idmon == id);
        }
    }
}
