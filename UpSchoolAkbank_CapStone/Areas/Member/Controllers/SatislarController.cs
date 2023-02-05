using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolAkbank_CapStone.Areas.Member.Controllers
{
    [Area("Member")]
    public class SatislarController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        SatislarManager satislarManager = new SatislarManager(new EfSatislarDal());

        private readonly UserManager<AppUser> _userManager;

        public SatislarController(UserManager<AppUser> userManager) //Autonticate olan kullanıcının bilgisini almak için yazıyoruz
        {
            _userManager = userManager;
        }
        
        public IActionResult OldSatis()
        {
            return View();
        }
        public IActionResult CurrentSatislar()
        {
            return View();
        }
        public async Task<IActionResult> ApprovalSatislar() //onay bekleyen satışlar
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = satislarManager.GetListWithSatislarByWaitApproval(values.Id);

            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewSatis()
        {
            List<SelectListItem> values = (from x in productManager.TGetList() 
                                    select new SelectListItem
                                    { 
                                        Text = x.ProductName,
                                        Value = x.ProductID.ToString()
                                    }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewSatis(Satislar p)
        {
            p.AppUserId = 1;
            p.Status = "Onay Bekliyor";
            satislarManager.TInsert(p);
            return RedirectToAction("CurrentSatislar");
            
        }
    }
    

}
