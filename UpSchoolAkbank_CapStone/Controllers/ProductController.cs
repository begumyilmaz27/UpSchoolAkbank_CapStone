using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

        [HttpGet]
        public IActionResult ProductDetails(int id)
        {
            ViewBag.Id = id;
            var values = _productManager.TGetByID(id);
            return View(values);                
        }

        [HttpPost]
        public IActionResult ProductDetails(Product id)
        { 
            return View();
        }
    }
}
