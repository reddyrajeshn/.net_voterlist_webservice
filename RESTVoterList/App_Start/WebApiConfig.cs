using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RESTVoterList
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "Booth",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "Booth" }
            //    );
            //config.Routes.MapHttpRoute(
            //    name: "BoothByName",
            //    routeTemplate: "api/{controller}/name/{name}",
            //    defaults: new { name = RouteParameter.Optional, controller = "Booth" }
            //    );

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            
        }
    }
}
