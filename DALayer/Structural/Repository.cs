using DALayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        Context c = new Context();
        DbSet<T> _object; //DbSet den gelen değerlere karşılık _object kullanılacak
        ResponsModel<T> response = new ResponsModel<T>();

        public Repository()
        {
            _object = c.Set<T>();
            //burda object e herhangi bir model den değer gelebilir
            //object başta null geldiği için contractır metot tanımladı
        }


        public int Delete(int id)
        {
            T model = _object.ToList().Find(x => x.id == id);
            _object.Remove(model);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }


        public ResponsModel<T> Insert(T p)
        {
            try
            {
                _object.Add(p);
                c.SaveChanges();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
  
        }

        public ResponsModel<T> List()
        {
            try
            {
                response.ResponseList= _object.ToList();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess= false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
        public List<T> List(int id)
        {
            return _object.Where(x => x.id == id).ToList();
        }
        public int Update(T p)
        {
            c.Set<T>().AddOrUpdate(p);
            return c.SaveChanges();
        }
      
    }
}
