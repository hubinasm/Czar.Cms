using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using sample.Models;

namespace sample.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content content;
        public ContentController(IOptions<Content> option)
        {
            content = option.Value;
        }
        public IActionResult Index1()
        {
            var contents = new List<Content>();
            for(int i=1;i<11;i++)
            {
                contents.Add(new Models.Content { Id = i,title= $"{i}的标题", content=$"{i}的内容",status=1,addTime=System.DateTime.Now.AddDays(-i) });
            }


            return View(new ContentViewModel { Contents = contents });
        }

        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents = new List<Content> { content } });
        }
    }
}