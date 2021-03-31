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
    public class SpeakersController : Controller
    {
        private readonly MeetingContext _context;

        public SpeakersController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Speakers
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            //Sort
            ViewData["SpeakerSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["TopicSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            //Filter
            ViewData["CurrentFilter"] = searchString;


            var meetingContext =  _context.Speakers
                .Include(s => s.Meeting)
                .Include(s => s.AssignmentTopic)
                .AsNoTracking();


            // Filter
            if (!String.IsNullOrEmpty(searchString))
            {
                meetingContext = meetingContext.Where(s => s.Name.Contains(searchString)
                                || s.AssignmentTopic.Topic.Contains(searchString));
            }

            //sort
            switch (sortOrder)
            {
                case "name_desc":
                    meetingContext = meetingContext.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    meetingContext = meetingContext.OrderBy(s => s.Meeting.MeetingDate);
                    break;
                case "date_desc":
                    meetingContext = meetingContext.OrderByDescending(s => s.Meeting.MeetingDate);
                    break;
                default:
                    meetingContext = meetingContext.OrderBy(s => s.Name);
                    break;
            }

            return View(meetingContext);
        }

        // GET: Speakers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speakers
                .Include(s => s.AssignmentTopic)
                .Include(s => s.Meeting)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);



            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // GET: Speakers/Create
        public IActionResult Create()
        {
            ViewData["AssignmentTopicID"] = new SelectList(_context.AssignmentTopics, "ID", "Topic");
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "MeetingDate");

            return View();
        }

        // POST: Speakers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingID,AssignmentTopicID,Name")] Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssignmentTopicID"] = new SelectList(_context.AssignmentTopics, "ID", "Topic", speaker.AssignmentTopicID);
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "MeetingDate", speaker.MeetingID);
            return View(speaker);
        }

        // GET: Speakers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            ViewData["AssignmentTopicID"] = new SelectList(_context.AssignmentTopics, "ID", "Topic", speaker.AssignmentTopicID);
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "MeetingDate", speaker.MeetingID);
           
            return View(speaker);
        }

        // POST: Speakers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingID,AssignmentTopicID,Name")] Speaker speaker)
        {
            if (id != speaker.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakerExists(speaker.ID))
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
            ViewData["AssignmentTopicID"] = new SelectList(_context.AssignmentTopics, "ID", "Topic", speaker.AssignmentTopicID);
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "MeetingDate", speaker.MeetingID);
           
            return View(speaker);
        }
        //private void MeetingDropDownList(object selectedMeeting = null)
        //{
        //    var meetingQuery = from m in _context.Meetings
        //                           orderby m.MeetingDate
        //                           select m;
        //    ViewBag.MeetingID = new SelectList(meetingQuery.AsNoTracking(), "DepartmentID", "Name", selectedMeeting);
        //}
        // GET: Speakers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speakers
                .Include(s => s.AssignmentTopic)
                .Include(s => s.Meeting)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // POST: Speakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speaker = await _context.Speakers.FindAsync(id);
            _context.Speakers.Remove(speaker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerExists(int id)
        {
            return _context.Speakers.Any(e => e.ID == id);
        }
    }
}
