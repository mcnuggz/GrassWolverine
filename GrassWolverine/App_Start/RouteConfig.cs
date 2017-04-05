using System.Web.Mvc;
using System.Web.Routing;

namespace GrassWolverine
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Home",
                "{action}",
                new { action = "Index", controller = "Home" }
            );

            routes.MapRoute(
                "About",
                "{action}",
                new { action = "About", controller = "Home" }
            );

            routes.MapRoute(
                "Contact",
                "{action}",
                new { action = "Contact", controller = "Home" }
            );

        }
    }
}
