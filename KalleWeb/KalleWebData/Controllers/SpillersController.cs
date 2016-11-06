using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KalleWebData.Models;

namespace KalleWebData.Controllers
{
    public class SpillersController : Controller
    {
        private NyKalleDB db = new NyKalleDB();

        // GET: Spillers
        public ActionResult Index()
        {
            return View(db.tblSpiller.ToList());
        }

        // GET: Spillers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSpiller tblSpiller = db.tblSpiller.Find(id);
            if (tblSpiller == null)
            {
                return HttpNotFound();
            }
            return View(tblSpiller);
        }

        // GET: Spillers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spillers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CN_SpillerPK,CN_SpillerForNavn,CN_SpillerEfterNavn,CN_SpillerInit,CN_SpillerOptDato,CN_SpillerUdMeldDato,CN_SpillerFormand,CN_SpillerNastFormand,CN_SpillerKasser,CN_SpillerRevisor,CN_SpillerSkemaAnsv,CN_SpillerWebAnsv,CN_EMail,CN_AktivMedl,CN_PassivMedl,CN_ProveMedl")] tblSpiller tblSpiller)
        {
            if (ModelState.IsValid)
            {
                db.tblSpiller.Add(tblSpiller);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblSpiller);
        }

        // GET: Spillers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSpiller tblSpiller = db.tblSpiller.Find(id);
            if (tblSpiller == null)
            {
                return HttpNotFound();
            }
            return View(tblSpiller);
        }

        // POST: Spillers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CN_SpillerPK,CN_SpillerForNavn,CN_SpillerEfterNavn,CN_SpillerInit,CN_SpillerOptDato,CN_SpillerUdMeldDato,CN_SpillerFormand,CN_SpillerNastFormand,CN_SpillerKasser,CN_SpillerRevisor,CN_SpillerSkemaAnsv,CN_SpillerWebAnsv,CN_EMail,CN_AktivMedl,CN_PassivMedl,CN_ProveMedl")] tblSpiller tblSpiller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSpiller).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblSpiller);
        }

        // GET: Spillers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSpiller tblSpiller = db.tblSpiller.Find(id);
            if (tblSpiller == null)
            {
                return HttpNotFound();
            }
            return View(tblSpiller);
        }

        // POST: Spillers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblSpiller tblSpiller = db.tblSpiller.Find(id);
            db.tblSpiller.Remove(tblSpiller);
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
