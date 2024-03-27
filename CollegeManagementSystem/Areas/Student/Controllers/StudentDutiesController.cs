using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollegeManagementSystem.Areas.Student.Models;
using CollegeManagementSystem.Models;

namespace CollegeManagementSystem.Areas.Student.Controllers
{
    [Area("Student")]
    public class StudentDutiesController : Controller
    {
        private readonly CollegeContext _context;

        public StudentDutiesController(CollegeContext context)
        {
            _context = context;
        }

        // GET: Student/StudentDuties
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentDuties.ToListAsync());
        }

        // GET: Student/StudentDuties/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentDuty = await _context.StudentDuties
                .FirstOrDefaultAsync(m => m.Code == id);
            if (studentDuty == null)
            {
                return NotFound();
            }

            return View(studentDuty);
        }

        // GET: Student/StudentDuties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/StudentDuties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Description,Status")] StudentDuty studentDuty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentDuty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentDuty);
        }

        // GET: Student/StudentDuties/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentDuty = await _context.StudentDuties.FindAsync(id);
            if (studentDuty == null)
            {
                return NotFound();
            }
            return View(studentDuty);
        }

        // POST: Student/StudentDuties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Code,Description,Status")] StudentDuty studentDuty)
        {
            if (id != studentDuty.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentDuty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentDutyExists(studentDuty.Code))
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
            return View(studentDuty);
        }

        // GET: Student/StudentDuties/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentDuty = await _context.StudentDuties
                .FirstOrDefaultAsync(m => m.Code == id);
            if (studentDuty == null)
            {
                return NotFound();
            }

            return View(studentDuty);
        }

        // POST: Student/StudentDuties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var studentDuty = await _context.StudentDuties.FindAsync(id);
            if (studentDuty != null)
            {
                _context.StudentDuties.Remove(studentDuty);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentDutyExists(string id)
        {
            return _context.StudentDuties.Any(e => e.Code == id);
        }
    }
}
