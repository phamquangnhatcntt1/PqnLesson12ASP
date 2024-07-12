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
    public class PqnSACHesController : Controller
    {
        private PhamQuangNhat_2210900115Entities1 db = new PhamQuangNhat_2210900115Entities1();

        // GET: PqnSACHes
        public ActionResult PqnIndex()
        {
            var pqnSACH = db.PqnSACH.Include(p => p.PqnTACGIA);
            return View(pqnSACH.ToList());
        }

        // GET: PqnSACHes/Details/5
        public ActionResult PqnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PqnSACH pqnSACH = db.PqnSACH.Find(id);
            if (pqnSACH == null)
            {
                return HttpNotFound();
            }
            return View(pqnSACH);
        }

        // GET: PqnSACHes/Create
        public ActionResult PqnCreate()
        {
            ViewBag.pqnMaTG = new SelectList(db.PqnTACGIA, "PqnMaTG", "PqnTenTacGia");
            return View();
        }

        // POST: PqnSACHes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnCreate([Bind(Include = "pqnqMaSach,pqnTenSach,pqnSoTrang,pqnNamXB,pqnMaTG,pqnTrangThai")] PqnSACH pqnSACH)
        {
            if (ModelState.IsValid)
            {
                db.PqnSACH.Add(pqnSACH);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            ViewBag.pqnMaTG = new SelectList(db.PqnTACGIA, "PqnMaTG", "PqnTenTacGia", pqnSACH.pqnMaTG);
            return View(pqnSACH);
        }

        // GET: PqnSACHes/Edit/5
        public ActionResult PqnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PqnSACH pqnSACH = db.PqnSACH.Find(id);
            if (pqnSACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.pqnMaTG = new SelectList(db.PqnTACGIA, "PqnMaTG", "PqnTenTacGia", pqnSACH.pqnMaTG);
            return View(pqnSACH);
        }

        // POST: PqnSACHes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnEdit([Bind(Include = "pqnqMaSach,pqnTenSach,pqnSoTrang,pqnNamXB,pqnMaTG,pqnTrangThai")] PqnSACH pqnSACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnSACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            ViewBag.pqnMaTG = new SelectList(db.PqnTACGIA, "PqnMaTG", "PqnTenTacGia", pqnSACH.pqnMaTG);
            return View(pqnSACH);
        }

        // GET: PqnSACHes/Delete/5
        public ActionResult PqnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PqnSACH pqnSACH = db.PqnSACH.Find(id);
            if (pqnSACH == null)
            {
                return HttpNotFound();
            }
            return View(pqnSACH);
        }

        // POST: PqnSACHes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult PqnDeleteConfirmed(string id)
        {
            PqnSACH pqnSACH = db.PqnSACH.Find(id);
            db.PqnSACH.Remove(pqnSACH);
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
