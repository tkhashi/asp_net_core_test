using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApp.Controllers
{
    public class HelloController : Controller
    {

        [Route("Hello/{id?}/{name?}")]
        public IActionResult Index(int id, string name)
        {
            ViewData["message"] = "id = " + id + ", name = " + name;
            return View();
        }

/*        public List<string> list;

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
            ViewData["list"] = new string[] { };
            ViewData["listdata"] = list;
            return View();
        }

        [HttpPost]
        public IActionResult Form(string name, string mail, string tel)
        {
            string[] res = (string[])Request.Form["list"];
            string msg = "*";
            foreach(var item in res)
            {
                msg += "「" + item + "」";
            }
            ViewData["message"] = msg + " selected." ;
            ViewData["list"] = Request.Form["list"];
            ViewData["listdata"] = list;
            return View("index");
        }
*/    }
}
