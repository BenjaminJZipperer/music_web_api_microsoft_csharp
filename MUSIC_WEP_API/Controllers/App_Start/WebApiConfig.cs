using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
//overdue package: using System.Web.Http; (nuget)

namespace MUSIC_WEP_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();
            /*
             * Next, you need to specify the routing for your Web API. Create a new 
             * folder called \App_Start in your project. Add a new class and name it WebApiConfig. 
             * Add a Using statement at the top of this file to bring in the namespace System.Web.Http. 
             * Add a Register method in your WebApiConfig class.Next, you need to specify the routing for 
             * your Web API. Create a new folder called \App_Start in your project. Add a new class and 
             * name it WebApiConfig. Add a Using statement at the top of
             * this file to bring in the namespace System.Web.Http. 
             * Add a Register method in your WebApiConfig class. [btw whats your favorite drink?]
             */
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
