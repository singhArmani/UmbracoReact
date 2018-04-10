using Microsoft.Owin;
using Owin;
using Umbraco.Core;
using Umbraco.Core.Security;
using Umbraco.Web;
using Umbraco.Web.Security.Identity;
using Umbraco.IdentityExtensions;
using Umbraco_Learning;
using Umbraco.RestApi;

//To use this startup class, change the appSetting value in the web.config called 
// "owin:appStartup" to be "UmbracoStandardOwinStartup"

[assembly: OwinStartup("UmbracoStandardOwinStartup", typeof(UmbracoStandardOwinStartup))]

namespace Umbraco_Learning
{
    /// <summary>
    /// The standard way to configure OWIN for Umbraco
    /// </summary>
    /// <remarks>
    /// The startup type is specified in appSettings under owin:appStartup - change it to "StandardUmbracoStartup" to use this class
    /// </remarks>
    public class UmbracoStandardOwinStartup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            //ensure the default options are configured
            base.Configuration(app);

            app.ConfigureUmbracoRestApi(new UmbracoRestApiOptions()
            {
                //Modify the CorsPolicy as required
                CorsPolicy = new System.Web.Cors.CorsPolicy()
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true,
                    AllowAnyOrigin = true
                }
            });

  

            // Enabling the usage of auth token retrieved by backoffice user / login
            // Uncomment below line when testing the PoC website
            app.UseUmbracoBackOfficeTokenAuth();
           
        }
    }
}
