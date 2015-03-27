using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiToolBox
{
    public class WebApiToolBoxHttpMessageAssetHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string asset = request.GetRouteData().Values["asset"].ToString();

            if (asset == "Script")
            {
                return Scripts();
            }

            throw new NotSupportedException(asset + " Not support");
        }

        //media type for css:  text/css


        private Task<HttpResponseMessage> Scripts()
        {

            HttpResponseMessage r = new HttpResponseMessage()
            {
                Content = new StreamContent(GetType().Assembly.GetManifestResourceStream("WebApiToolBox.Assets.WebApiToolBox.js"))
            };
            //TODO:  add proper cache control here.  check for the date in the request, compare it to the date of the assembly, etc.
            //also, probably store handlebars in the assy, too and combine it with this.  
            r.Headers.CacheControl = new CacheControlHeaderValue()
            {
                NoCache = true
            };

            r.Content.Headers.ContentType = new MediaTypeHeaderValue("text/javascript");
            


            return Task.FromResult(r);
        }
    }
}