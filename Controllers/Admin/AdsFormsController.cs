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
    public class AdsFormsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdsFormsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdsForms
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AdsForm.Include(a => a.AdsType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdsForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsForm = await _context.AdsForm
                .Include(a => a.AdsType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsForm == null)
            {
                return NotFound();
            }

            return View(adsForm);
        }

        // GET: AdsForms/Create
        public IActionResult Create()
        {
            ViewData["AdsTypeId"] = new SelectList(_context.AdsType, "Id", "Name");
            return View();
        }

        // POST: AdsForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdsTypeId,Id,Name,Description,UpdatedDate,DeletedDate")] AdsForm adsForm)
        {
            if (ModelState.IsValid)
            {
                adsForm.CreatedDate = DateTime.Now;

                _context.Add(adsForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdsTypeId"] = new SelectList(_context.AdsType, "Id", "Name", adsForm.AdsTypeId);
            return View(adsForm);
        }

        // GET: AdsForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsForm = await _context.AdsForm.FindAsync(id);
            if (adsForm == null)
            {
                return NotFound();
            }
            ViewData["AdsTypeName"] = new SelectList(_context.AdsType, "Id", "Name", adsForm.AdsTypeId);
            return View(adsForm);
        }

        // POST: AdsForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdsTypeId,Id,Name,Description,CreatedDate,DeletedDate")] AdsForm adsForm)
        {
            if (id != adsForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    adsForm.UpdatedDate = DateTime.Now;

                    _context.Update(adsForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdsFormExists(adsForm.Id))
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
            ViewData["AdsTypeId"] = new SelectList(_context.AdsType, "Id", "Name", adsForm.AdsTypeId);
            return View(adsForm);
        }

        // GET: AdsForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsForm = await _context.AdsForm
                .Include(a => a.AdsType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsForm == null)
            {
                return NotFound();
            }

            return View(adsForm);
        }

        // POST: AdsForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adsForm = await _context.AdsForm.FindAsync(id);
            _context.AdsForm.Remove(adsForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdsFormExists(int id)
        {
            return _context.AdsForm.Any(e => e.Id == id);
        }
    }
}
