using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using Google.Cloud.BigQuery.V2;


namespace VisProject.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet("")]
        public IActionResult Index()   
        {
            
            var houses = new List<string>
            {
                "arryn",
                "baratheon",
                "greyjoy",
                "lannister",
                "martell",
                "nights_watch",
                "none",
                "targaryen",
                "stark",
                "tully",
                "tyrell",
                "wildling"
            };

            ViewBag.Houses = houses;
            string lan = "lannister";
            ViewBag.uinput = lan;
            return View();
        }


        [HttpPost("query")]
         public IActionResult UserQuery(string uinput)
         {
            Console.WriteLine(uinput);
            // Handle form submission
            ViewBag.uinput = uinput;
            var houses = new List<string>
            {
                "arryn",
                "baratheon",
                "greyjoy",
                "lannister",
                "martell",
                "nights_watch",
                "none",
                "targaryen",
                "stark",
                "tully",
                "tyrell",
                "wildling"
            };

            ViewBag.Houses = houses;
            return View("index");
         }      
    }
}
