using B_LAYER.Abstract;
using D_LAYER.Abstract;
using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDL _contactdal;

        public ContactManager(IContactDL contactdal)
        {
            _contactdal = contactdal;
        }

        public void ContactAdd(Contact contact)
        {
           _contactdal.Insert(contact);
        }
    } 
}
