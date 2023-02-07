using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CohesionWebEIS.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult  GetAllSalesOrderList(string CustomerName, string ProductID, string ProductName, int page = 1)
        //{
        //    int totCnt = default;
        //    int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["list_pageSize"]);

        //    int catID, prdID = default;

        //    catID = (string.IsNullOrWhiteSpace(CustomerName)) ? -1 : int.Parse(CustomerName);
        //    prdID = (string.IsNullOrWhiteSpace(ProductID)) ? -1 : int.Parse(ProductID);

        //    return View(list);
        //}

        //public ActionResult List(string CategoryID, string ProductID, string ProductName, int page = 1)
        //{

        //    ProductDAO dao = new ProductDAO();
        //    var list = dao.GetProductNorthList(catID, prdID, ProductName, page, pageSize, out totCnt);
        //    var list1 = dao.GetCategoryNorthList();
        //    dao.Dispose();
        //    PageInfoVO pager = new PageInfoVO
        //    {
        //        TotalItems = totCnt
        //        ,
        //        ItemsPerPage = pageSize
        //        ,
        //        CurrentPage = page
        //    };

        //    list1.Insert(0, new ComboItemVO { Code = "", CodeName = "카 테 고 리 명" });
        //    ViewData["Category"] = new SelectList(list1, "Code", "CodeName");
        //    ViewBag.Page = pager;
        //    ViewBag.CategoryID = CategoryID;
        //    ViewBag.ProductID = ProductID;
        //    ViewBag.ProductName = ProductName;

        //    return View(list);
        //}
    }
}