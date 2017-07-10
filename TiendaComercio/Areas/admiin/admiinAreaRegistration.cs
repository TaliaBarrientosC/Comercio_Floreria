using System.Web.Mvc;

namespace TiendaComercio.Areas.admiin
{
    public class admiinAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admiin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admiin_default",
                "admiin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}