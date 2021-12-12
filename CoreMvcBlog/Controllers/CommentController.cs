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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialCommentListByBlog(int id)
        {
          var value=  cm.ListAll(id);
            return PartialView(value);
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment com)
        {
            com.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            com.CommentStatus = true;
            com.BlogId = 8;
            cm.CommentAdd(com);
            return PartialView();
        }
    }
}
