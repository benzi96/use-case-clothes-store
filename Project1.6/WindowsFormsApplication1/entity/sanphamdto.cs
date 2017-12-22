using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.entity
{
    public class sanphamdto
    {
        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("Mã sản phẩm")]
        public string masp { get; set; }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string tensp { get; set; }
        [System.ComponentModel.DisplayName("Size")]
        public string size { get; set; }
        [System.ComponentModel.DisplayName("Hãng")]
        public string hang { get; set; }
        [System.ComponentModel.DisplayName("Giá bán")]
        public Nullable<decimal> giaban { get; set; }
        /*
        [System.ComponentModel.DisplayName("Giảm giá")]
        public Nullable<double> giamgia { get; set; }
        */ 
        [System.ComponentModel.DisplayName("Số lượng tồn kho")]
        public Nullable<int> soluongtonkho { get; set; }
        [System.ComponentModel.DisplayName("Ngày nhập")]
        public string ngaynhap { get; set; }

        public sanphamdto(sanpham entity)
        {
            id = entity.id;
            masp = entity.masp;
            tensp = entity.tensp;
            size = entity.size;
            hang = entity.hang;
            soluongtonkho = entity.soluongtonkho;
            giaban = entity.giaban;
            //giamgia = entity.giamgia;
            ngaynhap = entity.ngaynhap.ToString();
        }
    }
}
