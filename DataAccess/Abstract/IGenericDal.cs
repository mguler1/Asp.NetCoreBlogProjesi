using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IGenericDal<T>where T:class 
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
