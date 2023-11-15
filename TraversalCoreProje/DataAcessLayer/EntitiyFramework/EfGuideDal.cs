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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalse(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.SaveChanges();
        }

        public void ChangeToTrue(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.SaveChanges();
        }
    }
}
