using CoreMvcBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMvcBlog.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                CategoryName="Teknoloji",CategoryCount=10
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Yazılım",
                CategoryCount = 15
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Spor",
                CategoryCount = 5
            });
            return Json(new {jsonList=list});
        }
    }
}
