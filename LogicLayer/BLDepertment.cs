using DALayer.Structural;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class BLDepertment
    {
        DepartmentRepository Deprepo = new DepartmentRepository();
        ResponsModel<Departmans> respons = new ResponsModel<Departmans>();

        //public int Delete(int id)
        //{
        //    return Deprepo.Delete(id);
        //}

        //public int Add(Users user)
        //{

        //    if (user.Name != "" && user.SurName != "" && user.Password != "" && user.DepartmentId != 0)
        //    {
        //        return Userrepo.Insert(user);
        //    }
        //    else return -1;
        //}

        //public int Update(Users user)
        //{
        //    if (user.id == 0 || user.Name == "" || user.SurName == "" || user.Password == "" || user.DepartmentId == 0)
        //    {
        //        return -1;
        //    }
        //    return Userrepo.Update(user);
        //}
        public ResponsModel<Departmans> GetAll()
        {
            try
            {
                respons = Deprepo.List();
                respons.IsSuccess = true;

            }
            catch (Exception ex)
            {

                respons.IsSuccess = false;
                respons.ErrorMessage = ex.Message;
            }
            return respons;
            

        }

    }
}
