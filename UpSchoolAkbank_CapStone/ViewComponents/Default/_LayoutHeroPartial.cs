using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.ViewComponents.Default
{
    public class _LayoutHeroPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
