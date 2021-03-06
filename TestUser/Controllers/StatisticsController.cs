﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestUser.Models;

namespace TestUser.Controllers
{
    public class StatisticsController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: Statistics
        public ActionResult Index()
        {
            return db.Statistics.Any() ? View(db.Statistics.ToList()) : View();
        }

        // GET: Statistics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Statistics statistics = db.Statistics.Find(id);
            if (statistics == null)
            {
                return HttpNotFound();
            }
            return View(statistics);
        }

        // GET: Statistics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Statistics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description")] Statistics statistics)
        {
            if (ModelState.IsValid)
            {
                db.Statistics.Add(statistics);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statistics);
        }

        // GET: Statistics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Statistics statistics = db.Statistics.Find(id);
            if (statistics == null)
            {
                return HttpNotFound();
            }
            return View(statistics);
        }

        // POST: Statistics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description")] Statistics statistics)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statistics).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statistics);
        }

        // GET: Statistics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Statistics statistics = db.Statistics.Find(id);
            if (statistics == null)
            {
                return HttpNotFound();
            }
            return View(statistics);
        }

        // POST: Statistics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Statistics statistics = db.Statistics.Find(id);
            db.Statistics.Remove(statistics);
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
