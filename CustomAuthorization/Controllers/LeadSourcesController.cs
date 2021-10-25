using CustomAuthorization.Filters;
using CustomAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthorization.Controllers
{
    [CustomAuthenticationFilter]
    public class LeadSourcesController : Controller
    {
        [CustomAuthorize("SuperAdmin","Admin")]
        public ActionResult Index()
        {
            LeadManagementEntities db = new LeadManagementEntities();
            List<LeadSource> leadSources = db.LeadSources.ToList();
            return View(leadSources);
        }

        [CustomAuthorize("SuperAdmin")]
        // GET: LeadSources
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LeadSource leadSource)
        {
            if(ModelState.IsValid)
            {
                LeadManagementEntities db = new LeadManagementEntities();
                db.LeadSources.Add(leadSource);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leadSource);
        }

        [CustomAuthorize("SuperAdmin","Admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            LeadManagementEntities db = new LeadManagementEntities();
            LeadSource leadSource = db.LeadSources.Single(x => x.SourceId == id);
            return View(leadSource);
        }

        [HttpPost]
        public ActionResult Edit(LeadSource leadSource)
        {
            if (ModelState.IsValid)
            {
                LeadManagementEntities db = new LeadManagementEntities();
                db.Entry(leadSource).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leadSource);
        }

        [CustomAuthorize("SuperAdmin","Admin")]
        public ActionResult Details(int id)
        {
            LeadSource leadSource = new LeadSource();
            LeadManagementEntities db = new LeadManagementEntities();
            leadSource = db.LeadSources.Single(x => x.SourceId == id);
            return View(leadSource);
        }

        [CustomAuthorize("SuperAdmin")]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            LeadManagementEntities db = new LeadManagementEntities();
            LeadSource leadSource = db.LeadSources.Single(x => x.SourceId == id);
            return View(leadSource);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Deletes(int id)
        {
            LeadManagementEntities db = new LeadManagementEntities();
            LeadSource leadSource = db.LeadSources.Single(x => x.SourceId == id);
            db.LeadSources.Remove(leadSource);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}