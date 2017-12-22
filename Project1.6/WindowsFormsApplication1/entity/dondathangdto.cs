using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.entity
{
    public class dondathangdto
    {
        public int madondathang { get; set; }
        public Nullable<System.DateTime> ngaydathang { get; set; }

        public dondathangdto(dondathang entity)
        {
            madondathang = entity.madondathang;
            ngaydathang = entity.ngaydathang;
        }
    }
}
