using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMvc.Models;
using SaleWebMvc.Models.ViewModels;

namespace SaleWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Our Contact:";
            ViewData["Own"] = "André";
            ViewData["Email"] = "scafisystems@gmail.com";
            ViewData["Site"] = "www.scafisystems.com";

            return View();
        }

        public IActionResult SiteScafisystems()
        {
            ViewData["Site"] = "www.scafisystems.com";

            return Redirect("http://www.scafisystems.com");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
