using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Passcode.Models;
using Microsoft.AspNetCore.Http;

namespace Passcode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Count") == null)
            {
                HttpContext.Session.SetInt32("Count", 1);
            }
            int? count = HttpContext.Session.GetInt32("Count");

            ViewBag.Count = count;
            ViewBag.Code = TempData["newCode"];

            GenerateCode();
            Console.WriteLine(count);
            return View();
        }

        [HttpGet("increment")]
        public IActionResult Increment()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count++;
            HttpContext.Session.SetInt32("Count", (int) count);

            return RedirectToAction("Index");
        }

        [HttpGet("endsession")]
        public IActionResult EndSession()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }

        public void GenerateCode()
        {
            Increment();

            string library = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@%^&*?";
            char[] charArr = library.ToCharArray();
            Random rand = new Random();
            char[] passArr = new char[14];
            for(int idx = 0; idx < passArr.Length; idx++)
            {
                passArr[idx] = charArr[rand.Next(35)];
            }

            TempData["newCode"] = new string(passArr);
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
