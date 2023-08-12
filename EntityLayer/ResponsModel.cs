using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ResponsModel<T>
    {
            // Liste Başta null gelecek
            //sysytem.null ReferanceException hatası (nesne başvurusu bir nesneni örneğine ayarlanmadı) almamak için aşağıyı yazdı
            public ResponsModel()
            {
                ResponseList = new List<T>();
            }
            //birden fazla özellik dönderebilmek için bu model i tanımladık
            public bool IsSuccess { get; set; }
            public string ErrorMessage { get; set; }
            public List<T> ResponseList { get; set; }

            // bu üç propertyi metotların üstüne uygulayacağız
        

    }
}
