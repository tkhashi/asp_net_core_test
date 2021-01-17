﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SampleMVCApp.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["message"] = "*テーブルの表示";
            ViewData["header"] = new string[] { "id", "name", "mail" };
            ViewData["data"] = new string[][] {
                new string[] { "1", "Taro", "taro@yamada" },
                new string[] { "2", "Hanako", "hanako@flower" },
                new string[] { "3", "Sachiko", "sachiko@happy" }
            };
            return View();
        }
    }
}
