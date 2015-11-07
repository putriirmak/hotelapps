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
    public class HotelsInfoesController : Controller
    {
        private Hotel_ExtContext db = new Hotel_ExtContext();

        // GET: HotelsInfoes
        public ActionResult Index()
        {
            return View(db.HotelInfo.ToList());
        }

        // GET: HotelsInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelsInfo HotelInfo = db.HotelInfo.Find(id);
            if (HotelInfo == null)
            {
                return HttpNotFound();
            }
            return View(HotelInfo);
        }

        // GET: HotelsInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelsInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Password,Fullname,Email,Address,PhoneNumber,Description,Stars")] HotelsInfo HotelInfo)
        {
            if (ModelState.IsValid)
            {
                db.HotelInfo.Add(HotelInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(HotelInfo);
        }

        // GET: HotelsInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelsInfo HotelInfo = db.HotelInfo.Find(id);
            if (HotelInfo == null)
            {
                return HttpNotFound();
            }
            return View(HotelInfo);
        }

        // POST: HotelsInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Username,Password,Fullname,Email,Address,PhoneNumber,Description,Stars")] HotelsInfo HotelInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(HotelInfo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(HotelInfo);
        }

        // GET: HotelsInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotelsInfo HotelInfo = db.HotelInfo.Find(id);
            if (HotelInfo == null)
            {
                return HttpNotFound();
            }
            return View(HotelInfo);
        }

        // POST: HotelsInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HotelsInfo HotelInfo = db.HotelInfo.Find(id);
            db.HotelInfo.Remove(HotelInfo);
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
