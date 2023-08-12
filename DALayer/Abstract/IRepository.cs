using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer.Abstract
{
    public interface IRepository<T> where T : BaseModel
    {
        ResponsModel<T> Insert (T p);
        int Update(T p);
        int Delete (int id);
        ResponsModel<T> List ();
        T GetById (int id);
        List<T> List(int id);
    }
}
