using BusinessLayer.Concrete;
using DataAcessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature: ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {

            //var values = featureManager.GetList();

            //ViewBag.image1=featureManager.

            return View();

        }
    }
}