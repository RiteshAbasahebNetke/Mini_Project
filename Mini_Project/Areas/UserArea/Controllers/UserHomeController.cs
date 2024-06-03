using Mini_Project.Controllers;
using Mini_Project.CusAusFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Areas.UserArea.Controllers
{
    [UserCusAus]
    public class UserHomeController : Controller
    {
        Mini_Project_DbFirstEntities mpd = new Mini_Project_DbFirstEntities();
        // GET: UserArea/UserHome
        public ActionResult Home()
        {
            return View();
        }

    }
}