using BusinessLayer.Abstract;
using DataAcccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);    
        }
        //Void türünde olmadığı için başına RETURN eklememiz gerekiyor. 
        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TInsert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);    
        }
    }
}
