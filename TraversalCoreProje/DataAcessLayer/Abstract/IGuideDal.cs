using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IGuideDal : IGenericDal<Guide>
    {

        void ChangeToTrue(int id);


        void ChangeToFalse(int id);



    }
}
