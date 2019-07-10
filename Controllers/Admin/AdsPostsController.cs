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
    public class AdsPostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdsPostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdsPosts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AdsPost.Include(a => a.AdsForm).Include(a => a.AdsVendor);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> ViewIndex()
        {
            var applicationDbContext = _context.AdsPost.Include(a => a.AdsForm).Include(a => a.AdsVendor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdsPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsPost = await _context.AdsPost
                .Include(a => a.AdsForm)
                .Include(a => a.AdsVendor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsPost == null)
            {
                return NotFound();
            }

            return View(adsPost);
        }

        public async Task<IActionResult> ViewDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsPost = await _context.AdsPost
                .Include(a => a.AdsForm)
                .Include(a => a.AdsVendor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsPost == null)
            {
                return NotFound();
            }

            return View(adsPost);
        }

        // GET: AdsPosts/Create
        public IActionResult Create()
        {
            var adsTypes = _context.AdsType.ToList();
            adsTypes.Insert(0, new AdsType { Id = 0, Name = "Select" });

            ViewData["AdsTypeId"] = new SelectList(adsTypes, "Id", "Name");
            //ViewData["AdsFormId"] = new SelectList(_context.AdsForm, "Id", "Name");
            ViewData["AdsVendorId"] = new SelectList(_context.AdsVendor, "Id", "Name");
            return View();
        }

        public JsonResult GetAdsFormsByAdsType(int adsTypeId)
        {
            var adsForms = new List<AdsForm>();

            adsForms = (from x in _context.AdsForm
                        where x.AdsTypeId == adsTypeId
                        select x).ToList();

            return Json(new SelectList(adsForms, "Id", "Name"));
        }

        // POST: AdsPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Price,Price_IsDealable,LogoUrl,AdsFormId,AdsVendorId,Id,Name,Description,UpdatedDate,DeletedDate")] AdsPost adsPost)
        {
            if (ModelState.IsValid)
            {
                adsPost.CreatedDate = DateTime.Now;
                adsPost.Price = adsPost.Price_IsDealable ? null : adsPost.Price;

                _context.Add(adsPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdsFormId"] = new SelectList(_context.AdsForm, "Id", "Name", adsPost.AdsFormId);
            ViewData["AdsVendorId"] = new SelectList(_context.AdsVendor, "Id", "Name", adsPost.AdsVendorId);
            return View(adsPost);
        }

        // GET: AdsPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsPost = await _context.AdsPost.FindAsync(id);
            if (adsPost == null)
            {
                return NotFound();
            }
            ViewData["AdsFormId"] = new SelectList(_context.AdsForm, "Id", "Name", adsPost.AdsFormId);
            ViewData["AdsVendorId"] = new SelectList(_context.AdsVendor, "Id", "Name", adsPost.AdsVendorId);
            return View(adsPost);
        }

        // POST: AdsPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Price,Price_IsDealable,LogoUrl,AdsFormId,AdsVendorId,Id,Name,Description,CreatedDate,DeletedDate")] AdsPost adsPost)
        {
            if (id != adsPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    adsPost.UpdatedDate = DateTime.Now;

                    _context.Update(adsPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdsPostExists(adsPost.Id))
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
            ViewData["AdsFormId"] = new SelectList(_context.AdsForm, "Id", "Name", adsPost.AdsFormId);
            ViewData["AdsVendorId"] = new SelectList(_context.AdsVendor, "Id", "Name", adsPost.AdsVendorId);
            return View(adsPost);
        }

        // GET: AdsPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adsPost = await _context.AdsPost
                .Include(a => a.AdsForm)
                .Include(a => a.AdsVendor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adsPost == null)
            {
                return NotFound();
            }

            return View(adsPost);
        }

        // POST: AdsPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adsPost = await _context.AdsPost.FindAsync(id);
            _context.AdsPost.Remove(adsPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdsPostExists(int id)
        {
            return _context.AdsPost.Any(e => e.Id == id);
        }
    }
}
