using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.controller
{
    public class chitiethoadoncontroller
    {
        public IRepository<chitiethoadon> cthdrp;
        public chitiethoadoncontroller()
        {
            cthdrp = new GenericRepository<chitiethoadon>();
        }

        public List<chitiethoadondto> timdethongke(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            return cthdrp.Find(c => c.hoadon.ngayban >= ngaynhaptu && c.hoadon.ngayban < ngaynhapden).Select(c => new chitiethoadondto(c)).ToList();
        }
        public List<sanphambanchaydto> soluongbanranhieunhat(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            sanphamcontroller spc = new sanphamcontroller();
            var query =
                        (from p in spc.laytatca()//spc.sprp.GetAll()
                         let totalQuantity = (from op in cthdrp.GetAll()
                                              where op.id == p.id && op.hoadon.ngayban >= ngaynhaptu && op.hoadon.ngayban <= ngaynhapden
                                              select op.soluongmua).Sum()
                         where totalQuantity > 0
                         orderby totalQuantity descending
                         select new sanphambanchaydto
                         {
                             id = p.id,
                             masp = p.masp,
                             tensp = p.tensp,
                             giaban = p.giaban,
                             soluongbanra = totalQuantity,
                             doanhthu = p.giaban * totalQuantity
                         }).Take(10);
            return query.ToList();
        }
        public List<sanphambanchaydto> soluongbanraitnhat(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            sanphamcontroller spc = new sanphamcontroller();
            var query =
                        (from p in spc.laytatca()
                         let totalQuantity = (from op in cthdrp.GetAll()
                                              where op.id == p.id && op.hoadon.ngayban >= ngaynhaptu && op.hoadon.ngayban < ngaynhapden
                                              select op.soluongmua).Sum()
                         where totalQuantity > 0
                         orderby totalQuantity ascending
                         select new sanphambanchaydto
                         {
                             id = p.id,
                             masp = p.masp,
                             tensp = p.tensp,
                             giaban = p.giaban,
                             soluongbanra = totalQuantity,
                             doanhthu = p.giaban * totalQuantity
                         }).Take(10);
            return query.ToList();
        }
        public List<sanphambanchaydto> doanhthubanranhieunhat(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            sanphamcontroller spc = new sanphamcontroller();
            var query =
                        (from p in spc.laytatca()
                         let tongtien = (from op in cthdrp.GetAll()
                                         where op.id == p.id && op.hoadon.ngayban >= ngaynhaptu && op.hoadon.ngayban <= ngaynhapden
                                         select op.soluongmua * op.giaban).Sum()
                         let totalQuantity = (from op in cthdrp.GetAll()
                                              where op.id == p.id && op.hoadon.ngayban >= ngaynhaptu && op.hoadon.ngayban <= ngaynhapden
                                              select op.soluongmua).Sum()
                         where tongtien > 0
                         orderby tongtien descending
                         select new sanphambanchaydto
                         {
                             id = p.id,
                             masp = p.masp,
                             tensp = p.tensp,
                             giaban = p.giaban,
                             soluongbanra = totalQuantity,
                             doanhthu = tongtien
                         }).Take(10);
            return query.ToList();
        }
        public List<sanphambanchaydto> doanhthubanraitnhat(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            sanphamcontroller spc = new sanphamcontroller();
            var query =
                        (from p in spc.laytatca()
                         let tongtien = (from op in cthdrp.GetAll()
                                              where op.id == p.id && op.hoadon.ngayban >= ngaynhaptu && op.hoadon.ngayban <= ngaynhapden
                                              select op.soluongmua*op.giaban).Sum()
                         let totalQuantity = (from op in cthdrp.GetAll()
                                              where op.id == p.id && op.hoadon.ngayban >= ngaynhaptu && op.hoadon.ngayban <= ngaynhapden
                                              select op.soluongmua).Sum()
                         where tongtien > 0
                         orderby tongtien ascending
                         select new sanphambanchaydto
                         {
                             id = p.id,
                             masp = p.masp,
                             tensp = p.tensp,
                             giaban = p.giaban,
                             soluongbanra = totalQuantity,
                             doanhthu = tongtien
                         }).Take(10);
            return query.ToList();
        }

        public decimal? doanhthutheothang(int thang, int year)
        {
            return cthdrp.Find(c => c.hoadon.ngayban.Value.Month == thang && c.hoadon.ngayban.Value.Year == year).Sum(c => (c.giaban * c.soluongmua));
        }
    }
}
