using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //default action of the entire application
        
        public IActionResult Index()
        {
            return View();
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
        
        //Its possible to call this using an alternate name too
        [ActionName("mvcone")]
        //However this searches for your html to be in this name
        //to get around that we need to mention in View() that we are 
        //referring to the same call
        public IActionResult MyMVC() 
        {
            return View("MyMVC");
        }

        //Foo is an alias for Privacy
        public IActionResult Foo() 
        {
            return View("Privacy");
        }

        //by using a query to be passed in like this
        //we dont need to modify the url.
        //instead we only need to modify the query input
        //?letterCase=lower
        public IActionResult Serial(string letterCase) 
        {
            //I dont want to return a View, as I want 
            // to only reach the input serial number and display it somewhere
            //return just a string
            var serial = "MYMVCPROJECT";
            if (letterCase == "lower")
            {
                //returning a content result
                return Content(serial.ToLower());
            }
            //else 
            //{
            //    return Content(serial);
            //}
            return Content(serial);
        }

        public IActionResult Date()
        {
            //string x = "SIMRANNNNNNNN";
            DateTime now = DateTime.Now;
            return Content(now.ToString("F"));
            //return Content(x);
        }

        [HttpGet]
        public IActionResult UserData() 
        {
            ViewBag.MyMessage = "Please Enter your Data";
            return View();
        
        }

        //the input query in your HttpPost method needs to match 
        //the text area in your Userdata.cshtml
        //When the user enters the message in UserData of the HttpGet
        //it is sent to the HttpPost
        [HttpPost]
        public IActionResult UserData(string message)
        {
            ViewBag.MyMessage = "Got The Message";
            return View();

        }

    }
    
}
