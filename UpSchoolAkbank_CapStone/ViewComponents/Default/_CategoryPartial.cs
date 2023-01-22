using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.ViewComponents.Default
{
    public class _CategoryPartial:ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.TGetList();
            return View(values);
        }

    }
}
