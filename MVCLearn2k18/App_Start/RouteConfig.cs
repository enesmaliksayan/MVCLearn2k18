using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCLearn2k18
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // bu alttaki fonksiyon controller içinde route tanımlamaya olanak veriyor.
            // routeconfig yerine controller içinde ilgili action'ın üstüne 1 satır yazılır
            // bu yazılan satır ile path ve yol taraflı regex yapılabilir.
            // MoviesController içinde ByReleaseDate actionresult üstünde örneği var.
            routes.MapMvcAttributeRoutes();


            /* routes.MapRoute(
                 name: "MoviesByReleaseDate",
                 url: "movies/released/{year}/{month}",
                 defaults: new { controller = "Movies", action = "ByReleaseDate" },
                 new { year = @"1[8-9]\d{2}|20[0-1][0-9]", month = @"0[1-9]|10|11|12" }
             );
             */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
