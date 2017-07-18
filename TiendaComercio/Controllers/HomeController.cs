using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaComercio.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaaEntities bd = new Models.TiendaaEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string id="")
        {
            //logica de acceso a bd
            var productos = bd.Producto.Where(x=>x.Descripcion.Contains(id)).Take(20).ToList();
            //lista de productos
            ViewBag.clave = id;
            return View(productos);
        }
        public ActionResult Nosotros()
        {
            return View();
        }
        public ActionResult Contactanos()
        {
            return View();
        }
    }
}