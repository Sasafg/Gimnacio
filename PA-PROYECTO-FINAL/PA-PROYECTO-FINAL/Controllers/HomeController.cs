using PA_PROYECTO_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PA_PROYECTO_FINAL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult About()
        {
            using (var db = new ProyFinalEntities())
            {
                List<Producto> productos = db.Producto.ToList();
                return View(productos);

                //List<Producto> products = db.Producto.ToList();
                //return View(products);

            }
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}