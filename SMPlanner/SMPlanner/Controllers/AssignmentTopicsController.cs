using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SMPlanner.Data;
using SMPlanner.Models;

namespace SMPlanner.Controllers
{
    public class AssignmentTopicsController : Controller
    {
        private readonly MeetingContext _context;

        public AssignmentTopicsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: AssignmentTopics
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            //Sort
            ViewData["TopicSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            //Filter
            ViewData["CurrentFilter"] = searchString;


            var meeting = _context.AssignmentTopics
                .Include(s => s.Speakers)
                    .ThenInclude(s => s.Meeting)
                .AsNoTracking();

            // Filter
            if (!String.IsNullOrEmpty(searchString))
            {
                meeting = meeting.Where(s => s.Topic.Contains(searchString));
            }

            //sort
            switch (sortOrder)
            {
                case "name_desc":
                    meeting = meeting.OrderByDescending(s => s.Topic);
                    break;

                default:
                    meeting = meeting.OrderBy(s => s.Topic);
                    break;
            }

            return View(await _context.AssignmentTopics.ToListAsync());
        }

        // GET: AssignmentTopics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignmentTopic = await _context.AssignmentTopics
                 .Include(s => s.Speakers)
                    .ThenInclude(e => e.Meeting)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (assignmentTopic == null)
            {
                return NotFound();
            }

            return View(assignmentTopic);
        }

        // GET: AssignmentTopics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AssignmentTopics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Topic")] AssignmentTopic assignmentTopic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assignmentTopic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assignmentTopic);
        }

        // GET: AssignmentTopics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignmentTopic = await _context.AssignmentTopics.FindAsync(id);
            if (assignmentTopic == null)
            {
                return NotFound();
            }
            return View(assignmentTopic);
        }

        // POST: AssignmentTopics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Topic")] AssignmentTopic assignmentTopic)
        {
            if (id != assignmentTopic.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assignmentTopic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssignmentTopicExists(assignmentTopic.ID))
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
            return View(assignmentTopic);
        }

        // GET: AssignmentTopics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignmentTopic = await _context.AssignmentTopics
                .FirstOrDefaultAsync(m => m.ID == id);
            if (assignmentTopic == null)
            {
                return NotFound();
            }

            return View(assignmentTopic);
        }

        // POST: AssignmentTopics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assignmentTopic = await _context.AssignmentTopics.FindAsync(id);
            _context.AssignmentTopics.Remove(assignmentTopic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssignmentTopicExists(int id)
        {
            return _context.AssignmentTopics.Any(e => e.ID == id);
        }
    }
}
