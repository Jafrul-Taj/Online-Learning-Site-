using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityFrameWorkCorePractice;
using EntityFrameWorkCorePractice.Models.Data;

namespace EntityFrameWorkCorePractice.Controllers
{
    public class SiteUsersController : Controller
    {
        private readonly DemoContext _context;

        public SiteUsersController(DemoContext context)
        {
            _context = context;
        }

        // GET: SiteUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Siteusers.ToListAsync());
        }

        // GET: SiteUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var coursesOfJafrul = _context.Courses.Where(c => c.SiteUser.ID == 2).ToList();
            var siteUser = await _context.Siteusers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (siteUser == null)
            {
                return NotFound();
            }

            return View(siteUser);
        }

        // GET: SiteUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SiteUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,UserName,Password")] SiteUser siteUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siteUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(siteUser);
        }

        // GET: SiteUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteUser = await _context.Siteusers.FindAsync(id);
            if (siteUser == null)
            {
                return NotFound();
            }
            return View(siteUser);
        }

        // POST: SiteUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,UserName,Password")] SiteUser siteUser)
        {
            if (id != siteUser.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siteUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteUserExists(siteUser.ID))
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
            return View(siteUser);
        }

        // GET: SiteUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteUser = await _context.Siteusers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (siteUser == null)
            {
                return NotFound();
            }

            return View(siteUser);
        }

        // POST: SiteUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siteUser = await _context.Siteusers.FindAsync(id);
            _context.Siteusers.Remove(siteUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiteUserExists(int id)
        {
            return _context.Siteusers.Any(e => e.ID == id);
        }
    }
}
