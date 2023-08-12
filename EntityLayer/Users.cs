using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Users : BaseModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz."), MaxLength(25)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz."), MaxLength(25)]
        public string SurName { get; set; }
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz."), MaxLength(25)]
        public string Password { get; set; }

        [ForeignKey("DepartmentId")]
        public Departmans Department { get; set; }
    }
}
