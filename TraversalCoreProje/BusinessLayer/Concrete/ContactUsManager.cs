using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ContactuS t)
        {
            _contactUsDal.Insert(t);
        }

        public void TContactUsStatusChangetoFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactuS t)
        {
            throw new NotImplementedException();
        }

        public ContactuS TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactuS> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactuS> TGetListContactByFalse()
        {
            return _contactUsDal.GetListContactByFalse();
        }

        public List<ContactuS> TGetListContactByTrue()
        {
            return _contactUsDal.GetListContactByTrue();
        }

        public void TUpdate(ContactuS t)
        {
            throw new NotImplementedException();
        }
    }
}
