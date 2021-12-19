using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcBlog.ViewComponents.Writer
{
    public class WriterMessageNatification : ViewComponent
    {

        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = nm.ListAll();
            return View(values);
        }
    }
}