using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}
