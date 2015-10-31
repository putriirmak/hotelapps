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
    public class UserHotelsController : Controller
    {
        private Hotel_ExtContext db = new Hotel_ExtContext();

        // GET: UserHotels
        public ActionResult Index()
        {
            return View(db.UserHotels.ToList());
        }

        // GET: UserHotels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserHotel userHotel = db.UserHotels.Find(id);
            if (userHotel == null)
            {
                return HttpNotFound();
            }
            return View(userHotel);
        }

        // GET: UserHotels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserHotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Password,Fullname,Email,Address,PhoneNumber")] UserHotel userHotel)
        {
            if (ModelState.IsValid)
            {
                db.UserHotels.Add(userHotel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userHotel);
        }

        // GET: UserHotels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserHotel userHotel = db.UserHotels.Find(id);
            if (userHotel == null)
            {
                return HttpNotFound();
            }
            return View(userHotel);
        }

        // POST: UserHotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Username,Password,Fullname,Email,Address,PhoneNumber")] UserHotel userHotel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userHotel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userHotel);
        }

        // GET: UserHotels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserHotel userHotel = db.UserHotels.Find(id);
            if (userHotel == null)
            {
                return HttpNotFound();
            }
            return View(userHotel);
        }

        // POST: UserHotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserHotel userHotel = db.UserHotels.Find(id);
            db.UserHotels.Remove(userHotel);
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
