using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repository;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntitiyFramework
{
    public class EfContactUsDal : GenericRepository<ContactuS>, IContactUsDal
    {
        public void ContactUsStatusChangetoFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactuS> GetListContactByFalse()
        {
            using (var context = new Context())
            {
                var values = context.ContactuSeS.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactuS> GetListContactByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactuSeS.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
