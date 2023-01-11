using _20221223MVC.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20221223MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        /// <summary>
        /// 顯示所有欄位，照UnitPrice遞減排序
        /// </summary>
        /// <returns></returns>
        public ActionResult Index01()
        {
            var db = new Model1();
            var data = db.Products.Include("Categories").OrderByDescending(p => p.UnitPrice).ToList();
            return View(data);
        }
    
        /// <summary>
        /// 顯示Id,ProductName,按ProductName 遞增排序
        /// </summary>
        /// <returns></returns>
        public ActionResult Index02()
        {
            return View();
        }
    }
}