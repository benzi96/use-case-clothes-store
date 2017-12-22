using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.controller
{
    public class hoadoncontroller
    {
        IRepository<hoadon> hdrp = new GenericRepository<hoadon>();

        public bool add(hoadon entity)
        {
            sanphamcontroller spcontroller = new sanphamcontroller();
            foreach(chitiethoadon cthd in entity.chitiethoadons)
            {
                if (!spcontroller.capnhatsoluong(cthd.id, cthd.soluongmua)) return false;
            }
            return hdrp.Add(entity);
        }

        public int getcurrentid()
        {
            try { return hdrp.GetQuery().Max(c => c.mahoadon);}
            catch { return 0; }
        }
        public List<hoadondto> doanhthuhomnay()
        {
            DateTime now = DateTime.Now;
            return hdrp.Find(c => c.ngayban.Value.Day==now.Day && c.ngayban.Value.Month==now.Month && c.ngayban.Value.Year==now.Year).Select(c => new hoadondto(c)).ToList();
        }

        public List<hoadondto> timdethongke(DateTime ngaybantu, DateTime ngaybanden)
        {
            return hdrp.Find(c => c.ngayban >= ngaybantu && c.ngayban < ngaybanden).Select(c => new hoadondto(c)).ToList();
        }
    }
}
