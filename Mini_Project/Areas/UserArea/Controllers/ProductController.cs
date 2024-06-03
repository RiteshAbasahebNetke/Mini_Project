using Mini_Project.CusAusFilters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Areas.UserArea.Controllers
{
    [UserCusAus]
    public class ProductController : Controller
    {
        Mini_Project_DbFirstEntities mpd = new Mini_Project_DbFirstEntities();
        // GET: UserArea/Product
        public ActionResult Index()
        {
            ViewBag.ProductID = new SelectList(this.mpd.ProductTbls.ToList(), "ProductID", "ProductName");
            return View(this.mpd.ProductTbls.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(this.mpd.ProductTbls.ToList(), "ProductID", "ProductName");
            ViewBag.CategoryID = new SelectList(this.mpd.CategoryTbls.ToList(), "CategoryID", "CategoryName");
            ViewBag.MfgID = new SelectList(this.mpd.MfgTbls.ToList(), "MfgID", "MfgName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductTbl rec, List<Int64> chk)
        {
            this.mpd.ProductTbls.Add(rec);
            foreach(var temp in chk)
            {
                ProductColorTbl pcrec=new ProductColorTbl();
                pcrec.ColorID = temp;
                pcrec.ProductID = temp;
                this.mpd.ProductColorTbls.Add(pcrec);
            }
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Int64? id)
        {
            var rec = this.mpd.ProductTbls.Find(id);
            ViewBag.CategoryID = new SelectList(this.mpd.CategoryTbls.ToList(), "CategoryID", "CategoryName",rec.CategoryID);
            ViewBag.MfgID = new SelectList(this.mpd.MfgTbls.ToList(), "MfgID", "MfgName",rec.MfgID);
            ViewBag.ProductID = new SelectList(this.mpd.ProductTbls.ToList(), "ProductID", "ProductName");
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(ProductTbl rec, List<Int64> chk)
        {
            var oldcolor = this.mpd.ProductColorTbls.Where(p => p.ProductID == rec.ProductID);
            
            foreach(var temp in oldcolor)
            {
                this.mpd.ProductColorTbls.Remove (temp); 
            }
            var oldrec = this.mpd.ProductTbls.Find(rec.ProductID);
            oldrec.ProductName = rec.ProductName;
            oldrec.MfgID = rec.MfgID;
            oldrec.Price = rec.Price;
            oldrec.ProductDescription=rec.ProductDescription;
            oldrec.CategoryID = rec.CategoryID;

            foreach(var temp in chk)
            {
                ProductColorTbl pcrec=new ProductColorTbl();
                pcrec.ColorID = temp;
                pcrec.ProductID = rec.ProductID;
                this.mpd.ProductColorTbls.Add(pcrec);
            }
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(Int64? id)
        {
           var rec= this.mpd.ProductTbls.Find(id);
           return View(rec);
        }
        public ActionResult Delete(Int64? id)
        {
            var procolor = this.mpd.ProductColorTbls.Where(p => p.ProductID == id);
            foreach(var temp in procolor)
            {
                this.mpd.ProductColorTbls.Remove(temp);
            }

            var rec=this.mpd.ProductTbls.Find(id);
            this.mpd.ProductTbls.Remove(rec);
            this.mpd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}