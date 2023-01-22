using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace UpSchoolAkbank_CapStone.ViewComponents.Default
{
    public class _ProductPartial: ViewComponent
    {
        ProductManager productManager= new ProductManager(new EfProductDal());

        public IViewComponentResult Invoke()
        {
            var values = productManager.TGetList();
            return View(values);
        }
    }
}
