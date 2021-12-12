using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
           _writerDal = writerDal; 
        }

        public Writer GetById(int id)
        {
          return   _writerDal.GetById(id);
        }

        public List<Writer> ListAll()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }
    }
}
