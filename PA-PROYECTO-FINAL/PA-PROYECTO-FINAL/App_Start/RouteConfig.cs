using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PA_PROYECTO_FINAL
{
 
        public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

                routes.MapRoute(
                    name: "IniciarSesion",
                    url: "Account/Login",
                    defaults: new { controller = "Account", action = "Login" }
                );

                routes.MapRoute(
                    name: "Registrarse",
                    url: "Account/Register",
                    defaults: new { controller = "Account", action = "Register" }
                );

               routes.MapRoute(
               name: "About",
               url: "About",
               defaults: new { controller = "Home", action = "About" }
               );

               routes.MapRoute(
               name: "AgregarCarrito",
               url: "Carrito/AgregarCarrito/{id}",
               defaults: new { controller = "Carrito", action = "AgregarCarrito" }
       );


        }
    }

    }

