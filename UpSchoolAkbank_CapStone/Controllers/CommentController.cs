using BusinessLayer.Concrete;
using DataAcccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UpSchoolAkbank_CapStone.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment() 
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;            
            commentManager.TInsert(p); //TAdd değil de TInsert diye oluşturmuşum IGenericService de 
            return RedirectToAction("Index", "Destination");
        }
    }
}
