using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KidsStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                          name: "Register",
                          url: "dang-ky",
                          defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
                          namespaces: new[] { "KidsStore.Controllers" }
                      );

            routes.MapRoute(
               name: "Login",
               url: "dang-nhap",
               defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional },
               namespaces: new[] { "KidsStore.Controllers" }
           );
            routes.MapRoute(
              name: "Add Cart",
              url: "GioHang",
              defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
              namespaces: new[] { "KidsStore.Controllers" }
          );
            routes.MapRoute(
              name: "Search",
              url: "tim-kiem",
              defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
              namespaces: new[] { "KidsStore.Controllers" }
          );

            routes.MapRoute(
               name: "Gioi ",
               url: "san-pham",
               defaults: new { controller = "BE", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "KidsStore.Controllers" }
               );


            routes.MapRoute(
                name: "Gioi Thieu",
                url: "gioi-thieu",
                defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "KidsStore.Controllers" }
                );
            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "KidsStore.Controllers" }
          );
        }
                  
    }
}
