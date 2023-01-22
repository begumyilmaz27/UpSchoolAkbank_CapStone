using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());  
        public IActionResult Index()
        {
            var values = _productManager.TGetList();
            return View(values);
        }
    }
}
