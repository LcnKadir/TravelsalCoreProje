using BusinessLayer.Concrete;
using DataAcessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent

   
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        
        
        public IViewComponentResult Invoke()
        {


            var values = guideManager.TGetList();
                return View(values);
        }


    }
}
