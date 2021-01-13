using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApp.Controllers
{
    public class HelloController : Controller
    {

        public List<string> list;

        public HelloController()
        {
            list = new List<string>();
            list.Add("Japan");
            list.Add("USA");
            list.Add("UK");
        }

        public IActionResult Index()
        {
            ViewData["message"] = "Select item:";
            ViewData["list"] = "";
            ViewData["listdata"] = "list";
            return View();
        }

        [HttpPost]
        public IActionResult Form(string name, string mail, string tel)
        {
            ViewData["message"] = '"' + Request.Form["list"] + '"' + " selected." ;
            ViewData["list"] = Request.Form["list"];
            ViewData["listdata"] = list;
            return View("index");
        }
    }
}
