using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutaManager subAboutaManager = new SubAboutaManager(new EfSubAboutDal());
        public IViewComponentResult Invoke() 
        {
            var values = subAboutaManager.GetList();
            return View(values);
        }
    }
}
