using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        [ViewData]
        public string Message { get; set; } = "sample message";
        private string[][] data = new string[][]
        {
            new string[]{"Taro", "taro@yamada" },
            new string[]{"Hanako", "hanako@flower" },
            new string[]{"sachiko", "sachiko@happy" }
        };

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }

        public void OnGet()
        {
            Message = "これはMessageプロパティの値です。";
        }

        public string getData(int id)
        {
            string[] target = data[id];
            return "[名前:" + target[0] + ", メール:" + target[1] + "]";
        }
    }
}
