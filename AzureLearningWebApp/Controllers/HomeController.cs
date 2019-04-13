using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureLearningWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AdventureWorksEntities db = new AdventureWorksEntities();
            List<Product> products = db.Products.ToList();
            int i = 0;
            foreach (Product product in products)
            {
                if (i >= 5) break;

                Response.Write("product id:" + product.ProductID + ", product name:" + product.Name + "<br>");
                i++;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}