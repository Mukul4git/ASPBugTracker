using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPBugTracker.Data;
using ASPBugTracker.Models;

namespace ASPBugTracker.Controllers
{
    public class bugsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public bugsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: bugs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.bug.Include(b => b.Priority).Include(b => b.Status);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: bugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.bug == null)
            {
                return NotFound();
            }

            var bug = await _context.bug
                .Include(b => b.Priority)
                .Include(b => b.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bug == null)
            {
                return NotFound();
            }

            return View(bug);
        }

        // GET: bugs/Create
        public IActionResult Create()
        {
            ViewData["PriorityId"] = new SelectList(_context.Priority, "Id", "Name");
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Name");
            return View();
        }

        // POST: bugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StatusId,PriorityId,Name,Type,Description,Solution,Creator")] bug bug)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bug);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PriorityId"] = new SelectList(_context.Priority, "Id", "Name", bug.PriorityId);
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Name", bug.StatusId);
            return View(bug);
        }

        // GET: bugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.bug == null)
            {
                return NotFound();
            }

            var bug = await _context.bug.FindAsync(id);
            if (bug == null)
            {
                return NotFound();
            }
            ViewData["PriorityId"] = new SelectList(_context.Priority, "Id", "Name", bug.PriorityId);
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Name", bug.StatusId);
            return View(bug);
        }

        // POST: bugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StatusId,PriorityId,Name,Type,Description,Solution,Creator")] bug bug)
        {
            if (id != bug.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bug);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!bugExists(bug.Id))
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
            ViewData["PriorityId"] = new SelectList(_context.Priority, "Id", "Name", bug.PriorityId);
            ViewData["StatusId"] = new SelectList(_context.Status, "Id", "Name", bug.StatusId);
            return View(bug);
        }

        // GET: bugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.bug == null)
            {
                return NotFound();
            }

            var bug = await _context.bug
                .Include(b => b.Priority)
                .Include(b => b.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bug == null)
            {
                return NotFound();
            }

            return View(bug);
        }

        // POST: bugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.bug == null)
            {
                return Problem("Entity set 'ApplicationDbContext.bug'  is null.");
            }
            var bug = await _context.bug.FindAsync(id);
            if (bug != null)
            {
                _context.bug.Remove(bug);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool bugExists(int id)
        {
          return _context.bug.Any(e => e.Id == id);
        }
    }
}
