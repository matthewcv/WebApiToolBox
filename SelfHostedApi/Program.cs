using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;
using WebApiToolBox;
namespace SelfHostedApi
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.ReadLine();
            }
        }
    }


public class Startup
{
    public void Configuration(IAppBuilder app)
    {
#if DEBUG
        app.UseErrorPage();
#endif
        app.UseWelcomePage("/");

        HttpConfiguration config = new HttpConfiguration();
        config.UseWebApiToolBox();
        config.Routes.MapHttpRoute( 
                name: "DefaultApi", 
                routeTemplate: "api/{controller}/{id}", 
                defaults: new { id = RouteParameter.Optional } 
            );


        app.UseWebApi(config);
    }
}
}
