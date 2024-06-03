using Mini_Project.Areas.UserArea;
using Mini_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Project.Controllers
{
    public class CheckBoxListController : Controller
    {
        // GET: CheckBoxList
        Mini_Project_DbFirstEntities mpd=new Mini_Project_DbFirstEntities();
        
        public ActionResult GenerateCheckBoxList(Int64 id=0)
        {
            if (id == 0)
            {
                //first we have to load all colors

                var allcolors = from m in this.mpd.ColorTbls
                                select new CheckBoxVM
                                {
                                    Value=m.ColorID,
                                    Text=m.ColorName,
                                    IsSelected=false,
                                };
                return PartialView("CheckBoxListPartial", allcolors);
            }
            {
                //here we have to load all colors which belongs to the productid

                var allcolors = from m in this.mpd.ColorTbls
                                select new CheckBoxVM
                                {
                                    Value=m.ColorID,
                                    Text=m.ColorName,
                                    IsSelected=this.mpd.ProductColorTbls.Any(p=>p.ColorID==m.ColorID)
                                };
                return PartialView("CheckBoxListPartial",allcolors);
            }

        }
    }
}