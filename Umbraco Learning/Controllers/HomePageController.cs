using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.WebApi;
using Umbraco_Learning.Utility;
using UmbracoLearning.Domain.Content;

namespace Umbraco_Learning.Controllers
{
    public class HomePageController : UmbracoApiController
    {
        [System.Web.Http.AcceptVerbs("GET")]
        public IHttpActionResult HomePageData()
        {
            UmbracoHelper helper = new UmbracoHelper(UmbracoContext.Current);
            IPublishedContent content = helper.TypedContent(1056);
            HomePage home = new HomePage(content);
            
            
            return Ok(new { name = home.ArticleTitle2});
            }

            // GET: Data
    public IEnumerable<string> GetAllProducts()
    {
        return new[] { "Table", "Chair", "Desk", "Computer", "Beer fridge" };
    }
    }



    public class ReturnClass
    {
        public IHtmlString ArticleBodyText1 { get; set; }

        public IHtmlString ArticleBodyText2 { get; set; }

        public string ArticleTitle1 { get; set; }

        public string ArticleTitle2 { get; set; }

        public IHtmlString AsideText { get; set; }

        public string AsideTitle { get; set; }

        public IHtmlString BodyText { get; set; }

        public string FooterText { get; set; }

        public string PageTitle { get; set; }
    }
}
