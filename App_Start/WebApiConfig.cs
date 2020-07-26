using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web-API-Konfiguration und -Dienste

            // Web-API-Routen
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "ApiByColor",
                routeTemplate: "{controller}/color/{name}",
                defaults: new { name = @"^[a-z]+$" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           
            


        }
    }
}
