using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.entity
{
    public class hoadondto
    {
        [System.ComponentModel.DisplayName("Mã hóa đơn")]
        public int mahoadon { get; set; }
        [System.ComponentModel.DisplayName("Ngày bán")]
        public Nullable<System.DateTime> ngayban { get; set; }
        [System.ComponentModel.DisplayName("Tổng cộng")]
        public decimal? tongcong { get; set; }
        [System.ComponentModel.DisplayName("Tiền khách đưa")]
        public decimal? tienkhachdua { get; set; }

        public hoadondto(hoadon entity)
        {
            mahoadon = entity.mahoadon;
            ngayban = entity.ngayban;
            tongcong = 0;
            foreach(chitiethoadon cthd in entity.chitiethoadons)
            {
                tongcong += cthd.soluongmua * cthd.sanpham.giaban;
            }
            tienkhachdua = entity.tienkhachdua;
        }
    }
}
