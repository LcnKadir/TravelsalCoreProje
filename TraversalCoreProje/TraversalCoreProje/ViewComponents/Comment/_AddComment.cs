using BusinessLayer.Concrete;
using DataAcessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());

        //[HttpGet]
        public IViewComponentResult Invoke()
        {

            return View();
        }


        //[HttpPost]
        //public IViewComponentResult Invoke(EntitiyLayer.Concrete.Comment p)
        //{
        //    p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.CommentState = true;
        //    commentManager.TAdd(p);
        //    return View();

        //}

    }
}
