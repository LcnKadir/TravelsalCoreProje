using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repository;
using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.EntitiyFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {

                return c.Comments.Include(x => x.AppUser).ToList();

            }
        }

        public List<Comment> GeetListCommentWithDestinationAndUser(int id)
        {
            using (var c = new Context())
            {

                return c.Comments.Where(x => x.DestinationID == id).Include( x => x.AppUser).ToList();

            }
        }

        
    }
}
