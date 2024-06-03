using Mini_Project.CusAusFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Areas.UserArea.Controllers
{
    [UserCusAus]
    public class MfgController : Controller
    {
        // GET: UserArea/Mfg
        Mini_Project_DbFirstEntities mpd=new Mini_Project_DbFirstEntities();
        public ActionResult Index()
        {
            ViewBag.MfgID = new SelectList(this.mpd.MfgTbls.ToList(), "MfgID", "MfgName");
            return View(this.mpd.MfgTbls.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MfgID = new SelectList(this.mpd.MfgTbls.ToList(), "MfgID", "MfgName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(MfgTbl rec)
        {
            this.mpd.MfgTbls.Add(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64? id)
        {
            var rec = this.mpd.MfgTbls.Find(id);
            ViewBag.MfgID = new SelectList(this.mpd.MfgTbls.ToList(), "MfgID", "MfgName");
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(MfgTbl rec)
        {

            var oldrec = this.mpd.MfgTbls.Find(rec.MfgID);
            oldrec.MfgID = rec.MfgID;
            oldrec.MfgName = rec.MfgName;
            oldrec.Address = rec.Address;
            oldrec.EmailID = rec.EmailID;
            oldrec.WebsiteUrl = rec.WebsiteUrl;
            oldrec.ContactPersonName = rec.ContactPersonName;
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64? id)
        {
            var rec = this.mpd.MfgTbls.Find(id);
            this.mpd.MfgTbls.Remove(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}