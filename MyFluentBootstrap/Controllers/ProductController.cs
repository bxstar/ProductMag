﻿using MyFluentBootstrap.Models;
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
    }
}
