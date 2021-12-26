using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IMessage2Service: IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);
    }
}
