using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MinistreFin.Data;

namespace MinisitreFin.Controllers
{
    public class ActivitesController : Controller
    {
        private MinistreFinEntities db = new MinistreFinEntities();

        // GET: Activites
        public ActionResult Index()
        {
            var activites = db.Activites.Include(a => a.Type_Activite);
            return View(activites.ToList());
        }

        // GET: Activites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activite activite = db.Activites.Find(id);
            if (activite == null)
            {
                return HttpNotFound();
            }
            return View(activite);
        }

        // GET: Activites/Create
        public ActionResult Create()
        {
            ViewBag.Type_ActiviteID = new SelectList(db.Type_Activite, "ID", "Nom_type");
            return View();
        }

        // POST: Activites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Type_ActiviteID,Nom_activ,Objectif_activ,Date")] Activite activite)
        {
            if (ModelState.IsValid)
            {
                db.Activites.Add(activite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Type_ActiviteID = new SelectList(db.Type_Activite, "ID", "Nom_type", activite.Type_ActiviteID);
            return View(activite);
        }

        // GET: Activites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activite activite = db.Activites.Find(id);
            if (activite == null)
            {
                return HttpNotFound();
            }
            ViewBag.Type_ActiviteID = new SelectList(db.Type_Activite, "ID", "Nom_type", activite.Type_ActiviteID);
            return View(activite);
        }

        // POST: Activites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Type_ActiviteID,Nom_activ,Objectif_activ,Date")] Activite activite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Type_ActiviteID = new SelectList(db.Type_Activite, "ID", "Nom_type", activite.Type_ActiviteID);
            return View(activite);
        }

        // GET: Activites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activite activite = db.Activites.Find(id);
            if (activite == null)
            {
                return HttpNotFound();
            }
            return View(activite);
        }

        // POST: Activites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Activite activite = db.Activites.Find(id);
            db.Activites.Remove(activite);
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
