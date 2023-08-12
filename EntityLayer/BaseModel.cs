using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BaseModel
    {
        [Key]
        public int id { get; set; }
        public int CreUser { get; set; }
        public DateTime? DelDate { get; set; }
        public int? DelUser { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTime CreDate
        {
            //default value creDate için aşağıda
            get
            {
                return this.creDate.HasValue
                   ? this.creDate.Value
                   : DateTime.Now;
            }

            set { this.creDate = value; }
        }

        private DateTime? creDate = null;

    }
}
