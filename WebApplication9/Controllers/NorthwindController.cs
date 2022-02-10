using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class NorthwindController : Controller
    {
        private string _connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwnd;Integrated Security=true;";

        public ActionResult Index()
        {
            NorthwindManager mgr = new NorthwindManager(_connectionString);
            List<Product> products = mgr.GetProducts();
            NorthwindViewModel vm = new NorthwindViewModel();
            vm.Products = products;
            return View(vm);
        }
    }
}