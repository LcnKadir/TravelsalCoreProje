using BusinessLayer.Concrete;
using DataAcessLayer.Concrete;
using DataAcessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commenCount = context.Comments.Where(x => x.DestinationID == id).Count();
            var values = commentManager.TGetListCommentWithDestination(id);
            return View(values);

        }

    }
}
