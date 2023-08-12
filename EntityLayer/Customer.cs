using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Customer : BaseModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz."), MaxLength(25)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz."), MaxLength(25)]
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int TypeOfMembership { get; set; }
        
    }
}
