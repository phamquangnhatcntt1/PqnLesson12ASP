using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PqnLesson12ASP.Models;

namespace PqnLesson12ASP.Controllers
{
    public class PqnTACGIAsController : Controller
    {
        private PhamQuangNhat_2210900115Entities1 db = new PhamQuangNhat_2210900115Entities1();

        // GET: PqnTACGIAs
        public ActionResult PqnIndex()
        {
            return View(db.PqnTACGIA.ToList());
        }

        // GET: PqnTACGIAs/Details/5
        public ActionResult PqnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PqnTACGIA pqnTACGIA = db.PqnTACGIA.Find(id);
            if (pqnTACGIA == null)
            {
                return HttpNotFound();
            }
            return View(pqnTACGIA);
        }

        // GET: PqnTACGIAs/Create
        public ActionResult PqnCreate()
        {
            return View();
        }

        // POST: PqnTACGIAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnCreate([Bind(Include = "PqnMaTG,PqnTenTacGia")] PqnTACGIA pqnTACGIA)
        {
            if (ModelState.IsValid)
            {
                db.PqnTACGIA.Add(pqnTACGIA);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            return View(pqnTACGIA);
        }

        // GET: PqnTACGIAs/Edit/5
        public ActionResult PqnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PqnTACGIA pqnTACGIA = db.PqnTACGIA.Find(id);
            if (pqnTACGIA == null)
            {
                return HttpNotFound();
            }
            return View(pqnTACGIA);
        }

        // POST: PqnTACGIAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnEdit([Bind(Include = "PqnMaTG,PqnTenTacGia")] PqnTACGIA pqnTACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnTACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            return View(pqnTACGIA);
        }

        // GET: PqnTACGIAs/Delete/5
        public ActionResult PqnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PqnTACGIA pqnTACGIA = db.PqnTACGIA.Find(id);
            if (pqnTACGIA == null)
            {
                return HttpNotFound();
            }
            return View(pqnTACGIA);
        }

        // POST: PqnTACGIAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult PqnDeleteConfirmed(string id)
        {
            PqnTACGIA pqnTACGIA = db.PqnTACGIA.Find(id);
            db.PqnTACGIA.Remove(pqnTACGIA);
            db.SaveChanges();
            return RedirectToAction("PqnIndex");
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
