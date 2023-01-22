using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.ViewComponents.Default
{
    public class _ContactPartial: ViewComponent
    {
        ContactManager _contact = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = _contact.TGetList();
            return View(values);
        }
    }
}
