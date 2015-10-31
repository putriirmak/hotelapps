using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel.Models;
using Hotel_Ext.Models;

namespace Hotel_Ext.Controllers
{
    public class BedroomsController : Controller
    {
        private Hotel_ExtContext db = new Hotel_ExtContext();

        // GET: Bedrooms
        public ActionResult Index()
        {
            var bedrooms = db.Bedrooms.Include(b => b.BedroomType);
            return View(bedrooms.ToList());
        }

        // GET: Bedrooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bedroom bedroom = db.Bedrooms.Find(id);
            if (bedroom == null)
            {
                return HttpNotFound();
            }
            return View(bedroom);
        }

        // GET: Bedrooms/Create
        public ActionResult Create()
        {
            ViewBag.BedroomTypeId = new SelectList(db.BedRoomTypes, "Id", "BedRoomTypeCode");
            return View();
        }

        // POST: Bedrooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BedroomNumber,AvailabilityStatus,BedroomTypeId")] Bedroom bedroom)
        {
            if (ModelState.IsValid)
            {
                db.Bedrooms.Add(bedroom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BedroomTypeId = new SelectList(db.BedRoomTypes, "Id", "BedRoomTypeCode", bedroom.BedroomTypeId);
            return View(bedroom);
        }

        // GET: Bedrooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bedroom bedroom = db.Bedrooms.Find(id);
            if (bedroom == null)
            {
                return HttpNotFound();
            }
            ViewBag.BedroomTypeId = new SelectList(db.BedRoomTypes, "Id", "BedRoomTypeCode", bedroom.BedroomTypeId);
            return View(bedroom);
        }

        // POST: Bedrooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BedroomNumber,AvailabilityStatus,BedroomTypeId")] Bedroom bedroom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bedroom).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BedroomTypeId = new SelectList(db.BedRoomTypes, "Id", "BedRoomTypeCode", bedroom.BedroomTypeId);
            return View(bedroom);
        }

        // GET: Bedrooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bedroom bedroom = db.Bedrooms.Find(id);
            if (bedroom == null)
            {
                return HttpNotFound();
            }
            return View(bedroom);
        }

        // POST: Bedrooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bedroom bedroom = db.Bedrooms.Find(id);
            db.Bedrooms.Remove(bedroom);
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
