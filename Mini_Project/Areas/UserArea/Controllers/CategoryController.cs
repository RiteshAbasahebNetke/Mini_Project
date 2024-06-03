using Mini_Project.CusAusFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Areas.UserArea.Controllers
{
    [UserCusAus]
    public class CategoryController : Controller
    {
        Mini_Project_DbFirstEntities mpd=new Mini_Project_DbFirstEntities();
        // GET: UserArea/Category
        public ActionResult Index()
        {
            ViewBag.CategoryID = new SelectList(this.mpd.CategoryTbls.ToList(),"CategoryID","CategoryName");
            return View(this.mpd.CategoryTbls.ToList());
        }
        [HttpGet]
        public ActionResult Create(Int64? id)
        {
            ViewBag.CategoryID = new SelectList(this.mpd.CategoryTbls.ToList(),"CategoryID","CategortName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoryTbl rec)
        {
            this.mpd.CategoryTbls.Add(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64? id)
        {
            var rec = this.mpd.CategoryTbls.Find(id);
            ViewBag.CategoryID = new SelectList(this.mpd.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(CategoryTbl rec)
        {
            var oldrec = this.mpd.CategoryTbls.Find(rec.CategoryID);
            oldrec.CategoryID = rec.CategoryID;
            oldrec.CategoryName = rec.CategoryName;
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(Int64? id)
        {
            var rec = this.mpd.CategoryTbls.Find(id);
            this.mpd.CategoryTbls.Remove(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}