using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IGenericService<T>
    {
        List<T> ListAll();
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        T GetById(int id);
    }
}
