using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcccessLayer.Abstract
{
    public interface ISatislarDal: IGenericDal<Satislar>
    {
        List<Satislar> GetListWithSatislarByWaitApproval(int id); //Onay bekleyen satışlar
        List<Satislar> GetListWithSatislarByAccepted(int id); //Oanaylanan satışlar
        List<Satislar> GetListWithSatislarByPrevious(int id); //Geçmiş satişlar
    }
}
