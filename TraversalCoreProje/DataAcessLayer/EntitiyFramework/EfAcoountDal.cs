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
    public class EfAcoountDal:GenericUowReporsitory<Account>, IAccountDal
    {
        public EfAcoountDal(Context context) : base(context)
        {
            

        }
    }
}
