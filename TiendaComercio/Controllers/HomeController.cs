using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaComercio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //cambio local 
            return View();
        }
        public ActionResult Buscar()
        {
            return View();
        }
        public ActionResult Producto(string id)
        {
            ViewBag.producto = id;
            return View();
        }
    }
}