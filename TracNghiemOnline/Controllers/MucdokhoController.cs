using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.Models;

namespace TracNghiemOnline.Controllers
{
    public class MucdokhoController : Controller
    {
        private readonly TracNghiemOnlineContext _context;

        public MucdokhoController(TracNghiemOnlineContext context)
        {
            _context = context;
        }

        // GET: Mucdokho
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mucdokhos.ToListAsync());
        }

        // GET: Mucdokho/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: Mucdokho/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Iddokho,Tendk")] Mucdokho mucdokho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mucdokho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mucdokho);
        }

        // GET: Mucdokho/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mucdokho = await _context.Mucdokhos.FindAsync(id);
            if (mucdokho == null)
            {
                return NotFound();
            }
            return View(mucdokho);
        }

        // POST: Mucdokho/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Iddokho,Tendk")] Mucdokho mucdokho)
        {
            if (id != mucdokho.Iddokho)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mucdokho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MucdokhoExists(mucdokho.Iddokho))
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
            return View(mucdokho);
        }

        // GET: Mucdokho/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mucdokho = await _context.Mucdokhos
                .FirstOrDefaultAsync(m => m.Iddokho == id);
            if (mucdokho == null)
            {
                return NotFound();
            }

            return View(mucdokho);
        }

        // POST: Mucdokho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mucdokho = await _context.Mucdokhos.FindAsync(id);
            _context.Mucdokhos.Remove(mucdokho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MucdokhoExists(int id)
        {
            return _context.Mucdokhos.Any(e => e.Iddokho == id);
        }
    }
}
