using DataAcccessLayer.Abstract;
using DataAcccessLayer.Concrete;
using DataAcccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcccessLayer.EntityFramework
{
    public class EfSatislarDal : GenericRepository<Satislar>, ISatislarDal
    {
        public List<Satislar> GetListWithSatislarByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Satislars.Include(x => x.Product).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
            }
        }

        public List<Satislar> GetListWithSatislarByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Satislars.Include(x => x.Product).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            }
        }

        public List<Satislar> GetListWithSatislarByWaitApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Satislars.Include(x => x.Product).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();
            }
        }
    }
}
