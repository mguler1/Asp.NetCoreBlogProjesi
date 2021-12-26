using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
  public  class EfMessageRepository:GenericRepository<Message>,IMessageDal
    {
    }
}
