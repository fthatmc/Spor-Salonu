using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Departmans : BaseModel
    {
        [Required(ErrorMessage = "Lütfen departman adını giriniz."), MaxLength(25)]
        public string Name { get; set; }
        public List<Users> Users { get; set; }
    }
}
