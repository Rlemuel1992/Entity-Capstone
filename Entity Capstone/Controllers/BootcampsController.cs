﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entity_Capstone.Models;

namespace Entity_Capstone.Controllers
{
    public class BootcampsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bootcamps
        public ActionResult Index()
        {
            return View(db.Bootcamps.ToList());
        }

        // GET: Bootcamps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bootcamps bootcamps = db.Bootcamps.Find(id);
            if (bootcamps == null)
            {
                return HttpNotFound();
            }
            return View(bootcamps);
        }

        // GET: Bootcamps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bootcamps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Class_Name,Category,Start_Date,End_Date")] Bootcamps bootcamps)
        {
            if (ModelState.IsValid)
            {
                db.Bootcamps.Add(bootcamps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bootcamps);
        }

        // GET: Bootcamps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bootcamps bootcamps = db.Bootcamps.Find(id);
            if (bootcamps == null)
            {
                return HttpNotFound();
            }
            return View(bootcamps);
        }

        // POST: Bootcamps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Class_Name,Category,Start_Date,End_Date")] Bootcamps bootcamps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bootcamps).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bootcamps);
        }

        // GET: Bootcamps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bootcamps bootcamps = db.Bootcamps.Find(id);
            if (bootcamps == null)
            {
                return HttpNotFound();
            }
            return View(bootcamps);
        }

        // POST: Bootcamps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bootcamps bootcamps = db.Bootcamps.Find(id);
            db.Bootcamps.Remove(bootcamps);
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
