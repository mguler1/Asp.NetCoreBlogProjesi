using Business.Concrete;
using Business.ValidationRules;
using CoreMvcBlog.Models;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcBlog.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbar()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var wValue = wm.GetById(1);
            return View(wValue);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult result = wl.Validate(p);
            if (result.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage x)
        {
            Writer w = new Writer();
            if (x.WriterImage!=null)
            {
                var extensions = Path.GetExtension(x.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extensions;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwrot/WriterImagesFile/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                x.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename; 
            }
            w.WriterMail = x.WriterMail;
            w.WriterNameSurname = x.WriterNameSurname;
            w.WriterPassword = x.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = x.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index");
        }
    }
}
