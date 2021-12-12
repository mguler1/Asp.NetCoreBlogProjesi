using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SubscibeManager : ISubscribeService
    {
        ISubscribeDal _subscribedal;

        public SubscibeManager(ISubscribeDal subscribedal)
        {
            _subscribedal = subscribedal;
        }

        public void MailAdd(Subsucribe subsucribe)
        {
            _subscribedal.Insert(subsucribe);
        }
    }
}
