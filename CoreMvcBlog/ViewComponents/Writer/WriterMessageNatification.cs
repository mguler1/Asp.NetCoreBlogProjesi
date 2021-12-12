using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcBlog.ViewComponents.Writer
{
    public class WriterMessageNatification : ViewComponent
    {

        public IViewComponentResult Invoke(int id)
        {

            return View();
        }
    }
}