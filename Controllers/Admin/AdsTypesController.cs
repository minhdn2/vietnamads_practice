using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VietnamAds_Practice.Data;
using VietnamAds_Practice.Models;

namespace VietnamAds_Practice.Controllers.Admin
{
    public class AdsTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdsTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdsTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdsType.ToListAsync());
        }

        // GET: AdsTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsType = await _context.AdsType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsType == null)
            {
                return NotFound();
            }

            return View(adsType);
        }

        // GET: AdsTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdsTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,UpdatedDate,DeletedDate")] AdsType adsType)
        {
            if (ModelState.IsValid)
            {
                adsType.CreatedDate = DateTime.Now;

                _context.Add(adsType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adsType);
        }

        // GET: AdsTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsType = await _context.AdsType.FindAsync(id);
            if (adsType == null)
            {
                return NotFound();
            }
            return View(adsType);
        }

        // POST: AdsTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreatedDate,DeletedDate")] AdsType adsType)
        {
            if (id != adsType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    adsType.UpdatedDate = DateTime.Now;

                    _context.Update(adsType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdsTypeExists(adsType.Id))
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
            return View(adsType);
        }

        // GET: AdsTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsType = await _context.AdsType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsType == null)
            {
                return NotFound();
            }

            return View(adsType);
        }

        // POST: AdsTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adsType = await _context.AdsType.FindAsync(id);
            _context.AdsType.Remove(adsType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdsTypeExists(int id)
        {
            return _context.AdsType.Any(e => e.Id == id);
        }
    }
}
