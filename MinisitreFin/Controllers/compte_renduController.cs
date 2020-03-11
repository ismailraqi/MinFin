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
    public class compte_renduController : Controller
    {
        private MinistreFinEntities db = new MinistreFinEntities();

        // GET: compte_rendu
        public ActionResult Index()
        {
            var compte_rendu = db.compte_rendu.Include(c => c.Activite);
            return View(compte_rendu.ToList());
        }

        // GET: compte_rendu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compte_rendu compte_rendu = db.compte_rendu.Find(id);
            if (compte_rendu == null)
            {
                return HttpNotFound();
            }
            return View(compte_rendu);
        }

        // GET: compte_rendu/Create
        public ActionResult Create()
        {
            ViewBag.ActivitesID = new SelectList(db.Activites, "ID", "Nom_activ");
            return View();
        }

        // POST: compte_rendu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ActivitesID,Titre_cr,Date_debut,Date_fin,Sujet1,Sujet2,Autre,Statut")] compte_rendu compte_rendu)
        {
            if (ModelState.IsValid)
            {
                db.compte_rendu.Add(compte_rendu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivitesID = new SelectList(db.Activites, "ID", "Nom_activ", compte_rendu.ActivitesID);
            return View(compte_rendu);
        }

        // GET: compte_rendu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compte_rendu compte_rendu = db.compte_rendu.Find(id);
            if (compte_rendu == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivitesID = new SelectList(db.Activites, "ID", "Nom_activ", compte_rendu.ActivitesID);
            return View(compte_rendu);
        }

        // POST: compte_rendu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ActivitesID,Titre_cr,Date_debut,Date_fin,Sujet1,Sujet2,Autre,Statut")] compte_rendu compte_rendu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compte_rendu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivitesID = new SelectList(db.Activites, "ID", "Nom_activ", compte_rendu.ActivitesID);
            return View(compte_rendu);
        }

        // GET: compte_rendu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compte_rendu compte_rendu = db.compte_rendu.Find(id);
            if (compte_rendu == null)
            {
                return HttpNotFound();
            }
            return View(compte_rendu);
        }

        // POST: compte_rendu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            compte_rendu compte_rendu = db.compte_rendu.Find(id);
            db.compte_rendu.Remove(compte_rendu);
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
