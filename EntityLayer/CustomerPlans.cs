using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CustomerPlans : BaseModel
    {
       
        public Customer customerId { get; set; }
        public Plans planId { get; set; }
    }
}
