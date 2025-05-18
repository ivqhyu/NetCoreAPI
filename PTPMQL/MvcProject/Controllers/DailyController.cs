using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcProject.Data;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class DailyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DailyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Daily
        public async Task<IActionResult> Index()
        {
            // return View(await _context.Daily.ToListAsync());
            var danhSachDaily = await _context.Daily
                .Include(d => d.HeThongPhanPhoi)  // Load dữ liệu từ bảng liên kết
                .ToListAsync();
            return View(danhSachDaily);
        }

        // GET: Daily/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var daily = await _context.Daily
                .FirstOrDefaultAsync(m => m.DaiLyID == id);
            if (daily == null)
            {
                return NotFound();
            }

            return View(daily);
        }

        // GET: Daily/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DaiLyID,TenDaiLy,DiaChi,NguoiDaiDien,DienThoai,MaHTPP")] Daily daily)
        {
            if (ModelState.IsValid)
            {
                _context.Add(daily);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaHTPP"] = new SelectList(await _context.HeThongPhanPhoi.ToListAsync(), "MaHTPP", "TenHTPP", daily.MaHTPP);
            return View(daily);
            
        }

        // GET: Daily/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var daily = await _context.Daily.FindAsync(id);
            if (daily == null)
            {
                return NotFound();
            }
            return View(daily);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DaiLyID,TenDaiLy,DiaChi,NguoiDaiDien,DienThoai,MaHTPP")] Daily daily)
        {
            if (id != daily.DaiLyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(daily);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyExists(daily.DaiLyID))
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
            return View(daily);
        }

        // GET: Daily/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var daily = await _context.Daily
                .FirstOrDefaultAsync(m => m.DaiLyID == id);
            if (daily == null)
            {
                return NotFound();
            }

            return View(daily);
        }

        // POST: Daily/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var daily = await _context.Daily.FindAsync(id);
            if (daily != null)
            {
                _context.Daily.Remove(daily);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DailyExists(string id)
        {
            return _context.Daily.Any(e => e.DaiLyID == id);
        }
    }
}
