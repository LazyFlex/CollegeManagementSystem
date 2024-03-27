using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollegeManagementSystem.Areas.Staff.Models;
using CollegeManagementSystem.Models;

namespace CollegeManagementSystem.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class StaffTasksController : Controller
    {
        private readonly CollegeContext _context;

        public StaffTasksController(CollegeContext context)
        {
            _context = context;
        }

        // GET: Staff/StaffTasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.StaffTasks.ToListAsync());
        }

        // GET: Staff/StaffTasks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffTask = await _context.StaffTasks
                .FirstOrDefaultAsync(m => m.TaskCode == id);
            if (staffTask == null)
            {
                return NotFound();
            }

            return View(staffTask);
        }

        // GET: Staff/StaffTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Staff/StaffTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskCode,TaskDescription,TaskLocation,TaskStatus")] StaffTask staffTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staffTask);
        }

        // GET: Staff/StaffTasks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffTask = await _context.StaffTasks.FindAsync(id);
            if (staffTask == null)
            {
                return NotFound();
            }
            return View(staffTask);
        }

        // POST: Staff/StaffTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TaskCode,TaskDescription,TaskLocation,TaskStatus")] StaffTask staffTask)
        {
            if (id != staffTask.TaskCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffTaskExists(staffTask.TaskCode))
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
            return View(staffTask);
        }

        // GET: Staff/StaffTasks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffTask = await _context.StaffTasks
                .FirstOrDefaultAsync(m => m.TaskCode == id);
            if (staffTask == null)
            {
                return NotFound();
            }

            return View(staffTask);
        }

        // POST: Staff/StaffTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var staffTask = await _context.StaffTasks.FindAsync(id);
            if (staffTask != null)
            {
                _context.StaffTasks.Remove(staffTask);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffTaskExists(string id)
        {
            return _context.StaffTasks.Any(e => e.TaskCode == id);
        }
    }
}
