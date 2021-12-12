using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdalDal;

        public ContactManager(IContactDal contactdalDal)
        {
            _contactdalDal = contactdalDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactdalDal.Insert(contact);
        }
    }
}
