using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PornoPageMVC.Models;

namespace PornoPageMVC.Controllers
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
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/Table/{size}")]
        public IActionResult RandomTable(int ParamSize = 3)
        {
            Random random = new Random();
            int[,] BidimensionalArray = new int[ParamSize, ParamSize];

            for (int i = 0; i < ParamSize; i++)
            {
                for (int j = 0; j < ParamSize; j++)
                {
                    BidimensionalArray[i, j] = random.Next(1, 10);
                }
            }

            ViewBag.Size = ParamSize;
            ViewBag.Table = BidimensionalArray;

            return View();
        }

        public IActionResult DiagonalTable(int ParamSize = 3)
        {
            ViewBag.Size = ParamSize;
            int[,] BidimensionalArray = new int[ParamSize, ParamSize];
            
            for (int i = 0; i < ParamSize; i++)
            {
                for (int j = 0; j < ParamSize; j++)
                {
                    BidimensionalArray[i, j] = Math.Abs((j - i) + 1);
                }
            }
            ViewBag.Table = BidimensionalArray;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
