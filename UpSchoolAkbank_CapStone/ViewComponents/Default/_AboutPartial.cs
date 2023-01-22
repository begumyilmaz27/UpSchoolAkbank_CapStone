using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        AboutManager _aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values=_aboutManager.TGetList();
            return View(values);    
        }
    }
}
