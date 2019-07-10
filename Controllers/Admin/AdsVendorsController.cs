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
    public class AdsVendorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdsVendorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdsVendors
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdsVendor.ToListAsync());
        }

        // GET: AdsVendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsVendor = await _context.AdsVendor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsVendor == null)
            {
                return NotFound();
            }

            return View(adsVendor);
        }

        // GET: AdsVendors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdsVendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,UpdatedDate,DeletedDate")] AdsVendor adsVendor)
        {
            if (ModelState.IsValid)
            {
                adsVendor.CreatedDate = DateTime.Now;

                _context.Add(adsVendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adsVendor);
        }

        // GET: AdsVendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsVendor = await _context.AdsVendor.FindAsync(id);
            if (adsVendor == null)
            {
                return NotFound();
            }
            return View(adsVendor);
        }

        // POST: AdsVendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreatedDate,DeletedDate")] AdsVendor adsVendor)
        {
            if (id != adsVendor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    adsVendor.UpdatedDate = DateTime.Now;

                    _context.Update(adsVendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdsVendorExists(adsVendor.Id))
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
            return View(adsVendor);
        }

        // GET: AdsVendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsVendor = await _context.AdsVendor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsVendor == null)
            {
                return NotFound();
            }

            return View(adsVendor);
        }

        // POST: AdsVendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adsVendor = await _context.AdsVendor.FindAsync(id);
            _context.AdsVendor.Remove(adsVendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdsVendorExists(int id)
        {
            return _context.AdsVendor.Any(e => e.Id == id);
        }
    }
}
