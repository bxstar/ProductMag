using MyFluentBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Mvc;
using XCode;
using System.Linq;
using System.Web.Http.OData.Query;

namespace MyFluentBootstrap.Controllers
{
    /// <summary>
    /// OData数据源控制器
    /// </summary>
    [Queryable(
        AllowedQueryOptions =
            AllowedQueryOptions.Format |
            AllowedQueryOptions.Top |
            AllowedQueryOptions.Skip |
            AllowedQueryOptions.InlineCount |
            AllowedQueryOptions.OrderBy
        )]
    public class ProductsController : ODataController
    {
        // GET odata/Data
        [Queryable]
        public System.Linq.IQueryable<Product> GetProducts()
        {
            List<Product> lstProduct = Product.FindAll().ToList();
            return lstProduct.AsQueryable();
        }

    }
}
