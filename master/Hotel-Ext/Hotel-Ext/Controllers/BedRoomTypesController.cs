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
    public class BedRoomTypesController : Controller
    {
        private Hotel_ExtContext db = new Hotel_ExtContext();

        // GET: BedRoomTypes
        public ActionResult Index()
        {
            return View(db.BedRoomTypes.ToList());
        }

        // GET: BedRoomTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BedRoomType bedRoomType = db.BedRoomTypes.Find(id);
            if (bedRoomType == null)
            {
                return HttpNotFound();
            }
            return View(bedRoomType);
        }

        // GET: BedRoomTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BedRoomTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BedRoomTypeCode,BedRoomName,ImageBedroom,SizeRoom")] BedRoomType bedRoomType)
        {
            if (ModelState.IsValid)
            {
                db.BedRoomTypes.Add(bedRoomType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bedRoomType);
        }

        // GET: BedRoomTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BedRoomType bedRoomType = db.BedRoomTypes.Find(id);
            if (bedRoomType == null)
            {
                return HttpNotFound();
            }
            return View(bedRoomType);
        }

        // POST: BedRoomTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BedRoomTypeCode,BedRoomName,ImageBedroom,SizeRoom")] BedRoomType bedRoomType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bedRoomType).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bedRoomType);
        }

        // GET: BedRoomTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BedRoomType bedRoomType = db.BedRoomTypes.Find(id);
            if (bedRoomType == null)
            {
                return HttpNotFound();
            }
            return View(bedRoomType);
        }

        // POST: BedRoomTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BedRoomType bedRoomType = db.BedRoomTypes.Find(id);
            db.BedRoomTypes.Remove(bedRoomType);
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
