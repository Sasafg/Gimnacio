using PA_PROYECTO_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PA_PROYECTO_FINAL.Controllers
{
    public class VentaController : Controller
    {

        private ProyFinalEntities bd = new ProyFinalEntities();
        // GET: Venta

        public ActionResult Index()
        {
            return View(bd.Venta.ToList().OrderBy(x => x.DiaVenta));
        }

        public ActionResult Detail(int id)
        {
            return View(bd.Venta.Find(id));

        }
     
    }
}
