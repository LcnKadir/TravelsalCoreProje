﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
