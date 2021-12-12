using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcBlog.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var liste = bm.GetListWithCategory();
            return View(liste);
        }
        [AllowAnonymous]
        public IActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var values = bm.GEtListWithCategoryByWriterBm(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in cm.ListAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.cv = categories;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            BlogValidator wv = new BlogValidator();
            ValidationResult results = wv.Validate(b);
            if (results.IsValid)
            {
                b.BlogStatus = true;
                b.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                b.WriterId = 1;
                bm.TAdd(b);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogfind = bm.GetById(id);
            bm.TDelete(blogfind);
            return RedirectToAction("BlogListByWriter");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in cm.ListAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.cv = categories;
            var blogfind = bm.GetById(id);
            return View(blogfind);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog b)
        {
            b.WriterId = 1;
            b.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            b.BlogStatus = true;
            bm.TUpdate(b);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
