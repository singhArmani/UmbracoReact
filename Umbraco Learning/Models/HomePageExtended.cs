using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace Umbraco_Learning.Models
{
    public class HomePageExtended : Umbraco.Web.PublishedContentModels.HomePage
    {
        public HomePageExtended(IPublishedContent content) : base(content)
        {
        }
        public string Number { get { return "test"; } }
    }
}