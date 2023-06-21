using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();
            ViewResult result = View("Main", ivm);
            result.StatusCode = 200;
            ViewData["Message"] = "Добрый день, это тестовый текст на главной странице";
            return result;
        }

        public IActionResult Privacy()
        {
            ViewData["Policy"] = "Текст политики конфидециальности";
            return View("Policy");
        }

        public IActionResult TestPage(int page)
        {
            ViewBag.PageIncrement = ++page;
            return View(new TestPageViewModel{Page = page});
        }

        
    }
}