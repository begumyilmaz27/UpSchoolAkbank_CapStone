using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> expression); //CommentList için şartlı getirme işlemi; ID ye göre yorumlar gelecek hepsi değil. 
        //T'ye göre Entity'e göre getirme işlemi demek. 
    }
}
