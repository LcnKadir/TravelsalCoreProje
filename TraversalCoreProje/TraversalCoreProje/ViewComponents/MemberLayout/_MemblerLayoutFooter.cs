using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemblerLayoutFooter: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}