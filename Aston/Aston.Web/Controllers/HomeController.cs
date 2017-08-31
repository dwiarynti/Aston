using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aston.Entities.DataContext;
using Aston.Business;

namespace Aston.Web.Controllers
{
    public class HomeController : Controller
    {
        AstonContext context = new AstonContext();
        AssetComponent assetservice = new AssetComponent();
       
        public IActionResult Index()
        {
            var a = assetservice.Asset();
            var b = a;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
