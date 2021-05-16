using onlineStore.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlineStore.Controllers
{
    public class HomeController : Controller
    {
        int N_of_Products = 4; 
        public ActionResult Index(string search, int? page)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search, N_of_Products, page));
        }

        public ActionResult AddToCart(int productId)
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();  
        }
    }
}
