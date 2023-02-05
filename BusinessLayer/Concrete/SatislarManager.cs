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
    public class SatislarManager : ISatislarService
    {
        ISatislarDal _satislarDal;

        public SatislarManager(ISatislarDal satislarDal)
        {
            _satislarDal = satislarDal;
        }

        public List<Satislar> GetListApprovalSatislar(int id)
        {
            return _satislarDal.GetListByFilter(x=> x.AppUserId== id);
        }

        public List<Satislar> GetListWithSatislarByAccepted(int id)
        {
            return _satislarDal.GetListWithSatislarByAccepted(id);
        }

        public List<Satislar> GetListWithSatislarByPrevious(int id)
        {
            return _satislarDal.GetListWithSatislarByPrevious(id);
        }

        public List<Satislar> GetListWithSatislarByWaitApproval(int id)
        {
            return _satislarDal.GetListWithSatislarByWaitApproval(id);
        }

        public void TDelete(Satislar t)
        {
            _satislarDal.Delete(t);
        }

        public Satislar TGetByID(int id)
        {
            return _satislarDal.GetByID(id);
        }

        public List<Satislar> TGetList()
        {
            return _satislarDal.GetList();
        }

        public void TInsert(Satislar t)
        {
            _satislarDal.Insert(t);
        }

        public void TUpdate(Satislar t)
        {
            _satislarDal.Update(t);
        }
    }
}
