using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Plans : BaseModel
    {
        [Required(ErrorMessage = "Lütfen program adını giriniz."), MaxLength(25)]
        public string Name { get; set; }
       
    }
}
