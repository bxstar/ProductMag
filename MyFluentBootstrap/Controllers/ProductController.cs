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
    /// <summary>
    /// 产品控制器，数据类型参考：http://www.chebao360.com/goods/index.php?cate=23&sort=24&brands=103&models=1171&outputs=3198&isnews=0&years=2012
    /// </summary>
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
                sb.AppendFormat("产品ID:{0},产品名称:{1},产品价格:{2},图片:{3}<br>", item.ProductID, item.ProductName, item.DisplayPrice, item.PicImgs);
            }
            sb.AppendFormat("<a href='/Product/Create' target='_blank' >新建</a>");
            return sb.ToString();
        }

        public ActionResult List(string searchkey, string index)
        {
            if (string.IsNullOrEmpty(index))
                index = "1";
            if (string.IsNullOrEmpty(searchkey))
                searchkey = string.Empty;
            else
                searchkey = searchkey.ToLower();

            List<Product> lstProduct = Product.FindAll().ToList();

            List<Product> totalList = lstProduct.Where(p =>
                p.ProductName.Contains(searchkey)
                || (p.SuitCar != null && p.SuitCar.Contains(searchkey))
                ).ToList();

            BasePageModel page = new BasePageModel("List") { SearchKeyWord = searchkey, CurrentIndex = Int32.Parse(index), TotalCount = totalList.Count };

            List<Product> pageList = totalList.Skip((page.CurrentIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            ViewData["pagemodel"] = page;
            ViewBag.SearchKey = searchkey;
            return View(pageList);

            //return View(Product.FindAll());
        }

        /// <summary>
        /// 提供给手机端查询
        /// </summary>
        /// <param name="ProductType">产品类型，前刹车片，后刹车片等</param>
        /// <param name="SuitCar">适用车型</param>
        /// <param name="ProductName">产品名称</param>
        /// <param name="index">页索引号</param>
        /// <returns>产品列表</returns>
        public ActionResult ListForMobile(string ProductType, string SuitCar, string ProductName, string index)
        {
            if (string.IsNullOrEmpty(index))
                index = "1";
            Dictionary<string, object> dicSearchCondition = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(ProductType))
            {
                dicSearchCondition.Add("ProductType", ProductType);
            }
            if (!string.IsNullOrEmpty(SuitCar))
            {
                dicSearchCondition.Add("SuitCar", SuitCar);
            }
            //模糊查询，使用linq
            if (ProductName == null)
            {
                ProductName = string.Empty;
            }
            List<Product> lstProduct = Product.FindAll(dicSearchCondition.Select(o => o.Key).ToArray(), dicSearchCondition.Select(o => o.Value).ToArray())
                .Where<Product>(x => x.ProductName.Contains(ProductName)).ToList();

            //分页使用
            //BasePageModel page = new BasePageModel("List") { SearchKeyWord = ProductName, CurrentIndex = Int32.Parse(index), TotalCount = lstProduct.Count };
            //List<Product> pageList = lstProduct.Skip((page.CurrentIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            //ViewData["pagemodel"] = page;

            ViewBag.SuitCar = SuitCar;
            ViewBag.ProductType = ProductType;
            ViewBag.ProductName = ProductName;
            return View(lstProduct);
        }

        /// <summary>
        /// 提供OData数据服务，参考：http://volaresystems.com/blog/post/2013/02/19/Using-Kendo-UI-grid-with-Web-API-and-OData
        /// </summary>
        public ActionResult MobileList(string searchKey)
        {

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Product p = Product.FindByProductID(id);
            return View(p);
        }

        public ActionResult DetailForMobile(int id)
        {
            Product p = Product.FindByProductID(id);
            return View(p);
        }

        public ActionResult Edit(int id)
        {
            Product p = Product.FindByProductID(id);

            return View(p);
        }

        public ActionResult Delete(int id)
        {
            Product p = Product.FindByProductID(id);
            p.Delete();
            return View("List",Product.FindAll());
        }

        [ValidateInput(false)]
        public string Add(Product p)
        {
            p.AddTime = p.LastUpdateTime = DateTime.Now;
            int result = p.Save();

            if (result > 0)
                return "编辑成功";
            else
                return "编辑失败";
        }


        [ValidateInput(false)]
        public string Update(Product p)
        {
            p.LastUpdateTime = DateTime.Now;

            int result = p.Update();
            if (result > 0)
                return "编辑成功";
            else
                return "编辑失败";
        }

        public string getmodel(int id)
        {
            return "<option value=\"404\">206</option><option value=\"405\">206 CC</option><option value=\"408\">207 CC</option><option value=\"406\">207(两厢)</option><option value=\"407\">207(三厢)</option><option value=\"415\">3008</option><option value=\"412\">307 CC</option><option value=\"411\">307 SW</option><option value=\"410\">307(两厢/国产)</option><option value=\"409\">307(两厢/进口)</option><option value=\"1042\">307(三厢)</option><option value=\"1081\">308</option><option value=\"414\">308 CC</option><option value=\"413\">308 SW</option><option value=\"1181\">4008</option><option value=\"416\">407</option><option value=\"418\">407 Coupe</option><option value=\"417\">407SW</option><option value=\"419\">408</option><option value=\"1180\">508</option><option value=\"420\">607</option><option value=\"1182\">RCZ</option>";
        }
    }
}
