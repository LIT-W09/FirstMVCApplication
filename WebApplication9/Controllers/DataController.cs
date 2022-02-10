using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Index()
        {
            DataViewModel vm = new DataViewModel();
            Random rnd = new Random();
            int number = rnd.Next(100, 1000);
            vm.RandomNumber = number;
            vm.RandomString = RandomString(20);
            return View(vm);
        }

        private static string RandomString(int length)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}