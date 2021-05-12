using LaundryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaundryManagement.Controllers
{
    public class ProductController : Controller
    {
        ProductContext db = new ProductContext();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult ShowProducts()
        {
            List<ProductModel> ProductList = new List<ProductModel>();
            ProductList.Add(new ProductModel { ProductId = 1, ProductName = "Shirt", ProductWashPrice=100, ProductDryPrice=200, ProductIronPrice = 100, ProductIsAvailable = true });
            ProductList.Add(new ProductModel { ProductId = 2, ProductName = "Jeens", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = false });
            ProductList.Add(new ProductModel { ProductId = 3, ProductName = "Pants", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = true });
            ProductList.Add(new ProductModel { ProductId = 4, ProductName = "Kurta", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = false });
            ViewBag.MyProduct = ProductList;
            return View();
        }
        public ActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProducts(ProductModel objProductModel)
        {
            int i=db.SaveProduct(objProductModel);
            if (i > 0)
            {
                return RedirectToAction("AddProducts");
            }
            else
            {
                return View();
            }
        }
        public ActionResult ShowProductsTotal()
        {
            List<ProductModel> ProductList = new List<ProductModel>();
            ProductList.Add(new ProductModel { ProductId = 1, ProductName = "Shirt", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = true });
            ProductList.Add(new ProductModel { ProductId = 2, ProductName = "Jeens", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = false });
            ProductList.Add(new ProductModel { ProductId = 3, ProductName = "Pants", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = true });
            ProductList.Add(new ProductModel { ProductId = 4, ProductName = "Kurta", ProductWashPrice = 100, ProductDryPrice = 200, ProductIronPrice = 100, ProductIsAvailable = false });
            ViewBag.MyProduct = ProductList;
            return View();
        }

        public ActionResult ShowColumnTotal()
        {
            return View();
        }

        public ActionResult TempDataExample()
        {
            TempData["userInfo"] = "PPy";

            return View();

        }
        public ActionResult TempDataExample2()
        {
            var t = TempData["userInfo"];
            ViewBag.info = t;
            return View();

        }

   
        //public ActionResult BillCust()
        //{
        //    LaundryManagmentSystemEntities db = new LaundryManagmentSystemEntities();
        //    list_cust_bill objlistCustBill = new list_cust_bill();
        //    objlistCustBill.listCustBill = db.tbl_Billing.ToList<tbl_Billing>();
        //    //ViewBag.message=
        //    return View(objlistCustBill);
        //}
    }
}