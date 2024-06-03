using Microsoft.Ajax.Utilities;
using Mini_Project.CusAusFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Areas.UserArea.Controllers
{
    [UserCusAus]
    public class ColorController : Controller
    {
        Mini_Project_DbFirstEntities mpd=new Mini_Project_DbFirstEntities();
        // GET: UserArea/Color
        public ActionResult Index()
        {
            ViewBag.ColorID = new SelectList(this.mpd.ColorTbls.ToList(), "ColorID", "ColorName");
            return View(this.mpd.ColorTbls.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ColorID = new SelectList(this.mpd.ColorTbls.ToList(), "ColorID", "ColorName");
            return View();
        }
        [HttpPost]
        public  ActionResult Create(ColorTbl rec)
        {
            this.mpd.ColorTbls.Add(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64? id)
        {
            var rec = this.mpd.ColorTbls.Find(id);
            ViewBag.ColorID = new SelectList(this.mpd.ColorTbls.ToList(), "ColorID", "ColorName");
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ColorTbl rec)
        {
            var oldrec = this.mpd.ColorTbls.Find(rec.ColorID);
            oldrec.ColorID = rec.ColorID;
            oldrec.ColorName = rec.ColorName;
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64? id)
        {
            var rec=this.mpd.ColorTbls.Find(id);
            this.mpd.ColorTbls.Remove(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}