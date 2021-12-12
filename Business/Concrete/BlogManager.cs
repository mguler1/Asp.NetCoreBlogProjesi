using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdalDal;

        public BlogManager(IBlogDal blogdalDal)
        {
            _blogdalDal = blogdalDal;
        }

     
        public Blog GetById(int id)
        {
            return _blogdalDal.GetById(id);
        }
        public List<Blog> GEtListWithCategoryByWriterBm(int id)
        {
           return _blogdalDal.GEtListWithCategoryByWriter(id);
        }
        public List<Blog>GetBlogById(int id)
        {
            return _blogdalDal.GetAll(x => x.BlogId == id);
        }
        public List<Blog> GetListWithCategory()
        {
            return _blogdalDal.GetListWithCategory();
        }

        public List<Blog> ListAll()
        {
            return _blogdalDal.GetAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogdalDal.GetAll().Take(3).ToList();
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return _blogdalDal.GetAll(x=>x.WriterId==id);
        }


        // refactoring start
        public void TAdd(Blog t)
        {
            _blogdalDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogdalDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogdalDal.Update(t);
        }
    }
}
