using DALayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DALayer.Migrations
{
    public class UserRepository : Repository<Users>,IUserRepository
    {
        Context c = new Context();
        
        public bool login(string username, string password)
        {
            Users user = new Users();
            user = c.Set<Users>().ToList().Find(x => x.Name == username && x.Password == password);
            if (user != null) return true;
            else return false;
        }
    }
}
