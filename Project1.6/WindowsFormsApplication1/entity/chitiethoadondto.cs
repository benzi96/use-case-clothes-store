using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.entity
{
    public class chitiethoadondto
    {
        [System.ComponentModel.DisplayName("Mã hóa đơn")]
        public int mahoadon { get; set; }
        [System.ComponentModel.DisplayName("STT")]
        public int stt { get; set; }
        [System.ComponentModel.DisplayName("ID sản phẩm")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string tensp { get; set; }
        [System.ComponentModel.DisplayName("Số lượng mua")]
        public Nullable<int> soluongmua { get; set; }
        [System.ComponentModel.DisplayName("Giá bán")]
        public Nullable<decimal> giaban { get; set; }
        [System.ComponentModel.DisplayName("Tổng cộng")]
        public Nullable<decimal> tongcong { get; set; }

        public chitiethoadondto(chitiethoadon entity)
        {
            mahoadon = entity.mahoadon;
            stt = entity.stt;
            id = entity.id;
            tensp = entity.sanpham.tensp + " " + entity.sanpham.size;
            giaban = entity.sanpham.giaban;
            soluongmua = entity.soluongmua;
            tongcong = soluongmua * giaban;
        }
    }
}
