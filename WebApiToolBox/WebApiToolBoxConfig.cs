using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.Routing;

namespace WebApiToolBox
{
    public static class WebApiToolBoxConfig
    {

        public static void RegisterRouteForTestClient(System.Web.Http.HttpConfiguration config)
        {
            config.Routes.Add("__WebApiToolBox_Assets", new HttpRoute("_WebApiToolBox/Assets/{asset}", null, null, null, new WebApiToolBoxHttpMessageAssetHandler()));
            config.Routes.Add("__WebApiToolBox", new HttpRoute("_WebApiToolBox", null, null, null, new WebApiToolBoxHttpMessageHandler()));
        }

    }
}
