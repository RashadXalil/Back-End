using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstHomeTask.Controllers
{
    public class HomeController:Controller
    {
        //public ContentResult def(int id,string name)
        //{
        //    //var res = new ContentResult();
        //    //res.Content =name +" " + id.ToString();
        //    //return res;
        //    return Content();
        //}
        //public JsonResult index()
        //{
        //    var res = new JsonResult(new { name = "Rashad", Surname = "Xalilov" });
        //    return res;


        //}
        public ActionResult Index()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "Index";
            //return view;
            return View("Index");
        }
        public ActionResult Aboutus()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "AboutUs";
            //return view;
            return View("Aboutus");
        }
        public ActionResult Contact()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Contact";
            return view;
        }
        public ActionResult Details( int id)
        {
            ViewBag.id = 90;
            ViewData["id"] = 40;



            TempData["id"] = 40;
            return View();
        }
    }
}
