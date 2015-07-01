using MyFluentBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using XCode;

namespace MyFluentBootstrap.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public string Index()
        {
            StringBuilder sb = new StringBuilder();

            EntityList<Product> lstProduct = Product.FindAll();
            foreach (var item in lstProduct)
            {
                sb.AppendFormat("商品ID:{0},商品名称:{1},商品价格:{2},图片:{3}<br>", item.ProductID, item.ProductName, item.DisplayPrice, item.PicImgs);
            }
            sb.AppendFormat("<a href='/Product/Create' target='_blank' >新建</a>");
            return sb.ToString();
        }

        public ActionResult List()
        {
            return View(Product.FindAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            Product p = Product.FindByProductID(id);
            p.Delete();
            return View("List",Product.FindAll());
        }

        public string Add(Product p)
        {
            p.AddTime = p.LastUpdateTime = DateTime.Now;
            int result = p.Save();

            return result.ToString();
        }

        
    }
}
