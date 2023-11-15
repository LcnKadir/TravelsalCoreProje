using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IContactUsDal: IGenericDal<ContactuS>
    {
        List<ContactuS> GetListContactByTrue();
        List<ContactuS> GetListContactByFalse();
        void ContactUsStatusChangetoFalse(int id);
    }
}
