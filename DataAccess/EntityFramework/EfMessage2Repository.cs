using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            {
                using (var c = new Context())
                {
                    //  return c.Messages2.Include(x => x.ReceiverUser).Where(x => x.Receiver == id).ToList();
                    return null;
                }
            }
        }
    }
}
