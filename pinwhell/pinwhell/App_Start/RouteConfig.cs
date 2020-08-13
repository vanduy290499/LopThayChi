using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pinwhell
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Home",
            url: "trang-chu",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "pinwhell.Controllers" }
        );
            routes.MapRoute(
             name: "About",
             url: "gioi-thieu",
             defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "pinwhell.Controllers" }
         );
            routes.MapRoute(
             name: "Courses",
             url: "cac-khoa-hoc",
             defaults: new { controller = "Courses", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "pinwhell.Controllers" }
         );
            routes.MapRoute(
            name: "Pricing",
            url: "dinh-gia",
            defaults: new { controller = "Pricing", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "pinwhell.Controllers" }
        );
            routes.MapRoute(
            name: "Blog",
            url: "bai-viet",
            defaults: new { controller = "Blog", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "pinwhell.Controllers" }
        );
            routes.MapRoute(
            name: "Contact",
            url: "lien-he",
            defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "pinwhell.Controllers" }
        );
            routes.MapRoute(
            name: "Blog Single",
            url: "blog/blog-single",
            defaults: new { controller = "Blog", action = "BlogSingle", id = UrlParameter.Optional },
            namespaces: new[] { "pinwhell.Controllers" }
        );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
