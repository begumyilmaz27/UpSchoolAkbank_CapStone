using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetCommentByID(id);
            return View(values);
        }
    }  
}
