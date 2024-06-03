using Mini_Project.Areas.UserArea;
using Mini_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Controllers
{
    public class ManageUserController : Controller
    {
        // GET: ManageUser

        Mini_Project_DbFirstEntities mpd = new Mini_Project_DbFirstEntities();

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(LoginVM rec)
        {
            var urec = this.mpd.UserTbls.SingleOrDefault(p => p.EmailID==rec.EmailID && p.Password == rec.Password);
            if (urec != null)
            {
                Session["UserID"] = urec.UserID;
                Session["FirstName"] = urec.FirstName;
                return RedirectToAction("Home", "UserHome", new { area = "UserArea" });
            }
            ModelState.AddModelError("", "Invalid EmailID or Password");
            return View(rec);
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserVM rec)
        {
                if (ModelState.IsValid)
            {
                UserTbl urec = new UserTbl();
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.Address = rec.Address;
                urec.EmailID = rec.EmailID;
                urec.MobileNo = rec.MobileNo;
                urec.Password = rec.Password;
                this.mpd.UserTbls.Add(urec);
                this.mpd.SaveChanges();

                return RedirectToAction("SignIn");
            }

            return View(rec);
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("SignIn");
        }

    }
}