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
            var productos = bd.Producto.Where(x=>x.Descripcion.Contains(id));
            //lista de productos
            return View(productos);
        }
        public ActionResult Producto(string id)
        {
            ViewBag.producto = id;
            return View();
        }
    }
}