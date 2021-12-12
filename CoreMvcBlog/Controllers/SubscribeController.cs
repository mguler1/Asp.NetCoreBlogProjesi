using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcBlog.Controllers
{
    public class SubscribeController : Controller
    {
        SubscibeManager sm = new SubscibeManager(new EfSubscribeRepository());
        [HttpGet]
        public PartialViewResult AddSubscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddSubscribe(Subsucribe a)
        {
            a.MailStatus = true;
            sm.MailAdd(a);
            return PartialView();
        }
    }
}
