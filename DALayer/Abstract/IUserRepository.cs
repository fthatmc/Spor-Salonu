using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer.Abstract
{
    public interface IUserRepository : IRepository<Users>
    {
        bool login(string KullaniciAdi, string Sifre);
        
    }
}
