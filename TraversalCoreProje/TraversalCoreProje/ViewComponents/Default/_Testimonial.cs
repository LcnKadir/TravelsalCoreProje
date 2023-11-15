using BusinessLayer.Concrete;
using DataAcessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        TestimonalManager testimonalManager = new TestimonalManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonalManager.TGetList();
            return View(values); 

        }
    }
}
