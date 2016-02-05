using System;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;

namespace Owin_Self_Host_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://127.0.0.1:8080/";

            using (WebApp.Start<Program>(baseAddress))
            {
                Console.WriteLine("Application started on {0}", baseAddress);
                Console.ReadKey();

            }
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.Routes.MapHttpRoute(
                name: "AppRoutes",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional });

            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}
