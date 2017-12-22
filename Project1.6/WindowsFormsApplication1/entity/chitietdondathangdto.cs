using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.entity
{
    public class chitietdondathangdto
    {
        [System.ComponentModel.DisplayName("Mã đơn đặt hàng")]
        public int madondathang { get; set; }
        [System.ComponentModel.DisplayName("STT")]
        public int stt { get; set; }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string tensp { get; set; }
        [System.ComponentModel.DisplayName("Số lượng đặt")]
        public Nullable<int> soluongdat { get; set; }
        [System.ComponentModel.DisplayName("Số lượng nhận")]
        public Nullable<int> soluongnhan { get; set; }
        [System.ComponentModel.DisplayName("Ngày đặt")]
        public Nullable<System.DateTime> ngaydat { get; set; }
        /*
        [System.ComponentModel.DisplayName("Giá nhập")]
        public Nullable<decimal> gianhap { get; set; }
         */ 
        [System.ComponentModel.DisplayName("Trạng thái")]
        public string trangthai { get; set; }
        /*
        [System.ComponentModel.DisplayName("Lí do")]
        public string lido { get; set; }
        [System.ComponentModel.DisplayName("Tình trạng")]
        public string tinhtrang { get; set; }
         */

        public chitietdondathangdto(chitietdondathang entity)
        {          
            stt = entity.stt;
            madondathang = entity.madondathang;
            tensp = entity.sanpham.tensp;
            soluongdat = entity.soluongdat;
            soluongnhan = entity.soluongnhan;
            //gianhap = entity.gianhap;
            trangthai = entity.trangthai;
            ngaydat = entity.dondathang.ngaydathang;
            //lido = entity.lido;
            //tinhtrang = entity.tinhtrang;
        }
    }
}
