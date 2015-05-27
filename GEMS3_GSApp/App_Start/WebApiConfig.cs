using GEMS3_GSApp.KendoUiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;

namespace GEMS3_GSApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //MapHttpAttributeRoutes()

            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<User>("Users");
            modelBuilder.EntitySet<ScanDetail>("ScanDetails");
            var model = modelBuilder.GetEdmModel();

            config.Routes.MapODataServiceRoute(
                routeName: "OData",
                routePrefix: "api",
                model: model
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
