using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;

namespace DALayer
{

    public class Context : DbContext
    {
        public Context() : base("name=Context")
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPlans> CustomerPlan { get; set; }
        public DbSet<Departmans> Departman { get; set; }
        public DbSet<Plans> Plan { get; set; }
        public DbSet<Users> User { get; set; }

    }
}
