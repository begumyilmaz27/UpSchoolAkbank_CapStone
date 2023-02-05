using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISatislarService : IGenericService<Satislar>
    {
        
        List<Satislar> GetListWithSatislarByWaitApproval (int id);
        List<Satislar> GetListWithSatislarByPrevious(int id);
        List<Satislar> GetListWithSatislarByAccepted(int id);
    }
}
