using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.ViewComponents.Default
{
    public class _NavbarPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
