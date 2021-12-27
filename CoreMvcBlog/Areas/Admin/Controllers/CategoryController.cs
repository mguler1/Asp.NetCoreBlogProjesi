using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace CoreMvcBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var value = cm.ListAll().ToPagedList(page,5);
            return View(value);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            CategoryValidator wv = new CategoryValidator();
            ValidationResult results = wv.Validate(c);
            if (results.IsValid)
            {
                c.CategoryStatus = true;
                //c.CategoryDescription=
                cm.TAdd(c);
                return RedirectToAction("Index", "Category");
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
        public IActionResult CategoryDelete(int id)
        {
            var value = cm.GetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
