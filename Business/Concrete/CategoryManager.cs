using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using DataAccess.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;
        public CategoryManager (ICategoryDal categoryDal)
        {
            _categorydal = categoryDal;
        }
        public Category GetById(int id)
        {
           return _categorydal.GetById(id);
        }

        public List<Category> ListAll()
        {
           return _categorydal.GetAll();
        }

        public void TAdd(Category t)
        {
            _categorydal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categorydal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categorydal.Update(t);
        }
    }
}