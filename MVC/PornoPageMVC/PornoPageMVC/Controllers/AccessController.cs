using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PornoPageMVC.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Access(string ParamName = "Anonym", int ParamYears = 0)
        {
            ViewBag.Name = ParamName;
            ViewBag.Years = ParamYears;

            if (ViewBag.Years >= 18)
            {
                return View();
            }
            else { return null; }
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
    }
}