using DALayer;
using DALayer.Migrations;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class BLUsers
    {
        UserRepository Userrepo = new UserRepository();
        ResponsModel<Users> respons = new ResponsModel<Users>();
        
        public ResponsModel<Users> Add(Users user)
        {
            try
            {
                if (user.Name != "" && user.SurName != "" && user.Password != "" && user.DepartmentId != 0)
                {
                   Userrepo.Insert(user);
                }
                respons.IsSuccess = true;

            }
            catch (Exception ex)
            {
                respons.IsSuccess = false;
                respons.ErrorMessage = ex.Message;
            }
            return respons;

           
        }

        public int Update(Users user)
        {
            if (user.id==0 || user.Name=="" || user.SurName=="" || user.Password=="" || user.DepartmentId==0)
            {
                return -1;
            }
            return Userrepo.Update(user);
        }
        public ResponsModel<Users> GetAll()
        {

            try
            {
                respons = Userrepo.List();
                respons.IsSuccess = true;

            }
            catch (Exception ex)
            {

                respons.IsSuccess=false;
                respons.ErrorMessage = ex.Message;
            }
            return respons;
           
        }

        public int Delete(int id)
        {
            return Userrepo.Delete(id);
        }


        public List<Users> GetAll(int id)
        {
            return Userrepo.List(id);

        }
        public bool login(string username, string password)
        {
            if (Userrepo.login(username, password))
            {
                return true;
            }
            else return false;
        }
    }
}
