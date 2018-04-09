using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Umbraco_Learning.Controllers
{
    public class DataController : UmbracoApiController
    {
        // GET: Data
        public IEnumerable<string> GetAllProducts()
        {
            return new[] { "Table", "Chair", "Desk", "Computer", "Beer fridge" };
        }

    }
}