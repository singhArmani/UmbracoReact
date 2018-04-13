using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;

namespace Umbraco_Learning.App_Start
{
    public class UmbracoApplicationEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            RouteTable.Routes.MapRoute(
                "Hello",
                "Data",
                new
                {
                    controller = "HomePage",
                    Action = "HomePageData",                    
                });
        }

    }
}