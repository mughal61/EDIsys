using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EDIsystems.Data;
using EDIsystems.Models.Jobs;
using EDIsystems.ViewModels;
using FluentDate;
using FluentDateTime;

namespace EDIsystems.Controllers
{
    public class JobsController : Controller
    {
        private JobsContext db = new JobsContext();

        // GET: Jobs
        public ActionResult Index()
        {
            var jobs = db.Jobs.Include(j => j.App);
            return View(jobs.ToList());
        }

        // GET: Jobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: Jobs/Create
        public ActionResult Create()
        {
            ViewBag.AppId = new SelectList(db.Apps, "AppId", "AppName");
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobId,Time,Day,Success,Files_DwUp,Files_Sorted,AppId")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AppId = new SelectList(db.Apps, "AppId", "AppName", job.AppId);
            return View(job);
        }

        public ActionResult ScheduledJobs(int val=0)
        {
            JobsScheduledJobsViewModel scheduledJobsVM = new JobsScheduledJobsViewModel()
            {
                daysList = new List<string>()
                {
                    "Sunday",
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday"
                },
                appsList = db.Apps.ToList(),
                jobsList = db.Jobs.ToList(),
                currentDate = DateTime.Now,
                weekNumber = val
            };
            
            var weekOld = DateTime.Today.Subtract(Convert.ToDateTime("12/05/2019"));
            var dateTime = 1.Weeks().Ago();
            int k = 0;
            var k2 = k.Weeks().Ago();
            var k3 = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Sunday).Date.ToString("d");
            var k4 = k2.DayOfWeek;
            var date = DateTimeExtensions.WeekEarlier(Convert.ToDateTime("12/05/2019"));
            return View(scheduledJobsVM);
        }


        // GET: Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppId = new SelectList(db.Apps, "AppId", "AppName", job.AppId);
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobId,Time,Day,Success,Files_DwUp,Files_Sorted,AppId")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppId = new SelectList(db.Apps, "AppId", "AppName", job.AppId);
            return View(job);
        }

        // GET: Jobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
