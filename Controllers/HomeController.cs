using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestingMVC.Models;

namespace TestingMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            return View();
        }

        public ViewResult Coba()
        {

            return View("TempView/ViewCoba.cshtml");
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
