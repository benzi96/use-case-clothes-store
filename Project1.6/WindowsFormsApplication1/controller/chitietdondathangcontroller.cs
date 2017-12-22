using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.controller
{
    public class chitietdondathangcontroller
    {
        public IRepository<chitietdondathang> ctddhrp;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();

        public chitietdondathangcontroller()
        {
            ctddhrp = new GenericRepository<chitietdondathang>();
        }

        /*public bool validate(chitietdondathang entity)
        {
            return true;
        }*/

        private static IEnumerable<chitietdondathang> ApplyAndPredicates(IEnumerable<Func<chitietdondathang, bool>> predicates, IEnumerable<chitietdondathang> ctddh)
        {
            var filteredctddh = ctddh;
            foreach (var predicate in predicates)
            {
                filteredctddh = filteredctddh.Where(predicate);
            }
            return filteredctddh;
        }

        public List<chitietdondathangdto> MeetCriteria(int? madon = null, int? soluongdat = null, int? soluongnhan = null, string tensanpham = null, string trangthai = null, DateTime? ngaydat = null, DateTime? ngaydatden = null)
        {
            var ctddh = ctddhrp.GetAll();
            var predicates = new List<Func<chitietdondathang, bool>>();
            if (madon != null) predicates.Add(s => s.madondathang == madon);
            if (soluongdat != null) predicates.Add(s => s.soluongdat == soluongdat);
            if (soluongnhan != null) predicates.Add(s => s.soluongnhan == soluongnhan);
            if (tensanpham != null) predicates.Add(s => s.sanpham.tensp == tensanpham);
            if (trangthai != null) predicates.Add(s => s.trangthai == trangthai);
            if (ngaydat != null)
            {
                predicates.Add(s => (s.dondathang.ngaydathang >= ngaydat && s.dondathang.ngaydathang < ngaydatden));
            }
            return ApplyAndPredicates(predicates, ctddh).Select(c => new chitietdondathangdto(c)).ToList();
        }

        public List<chitietdondathangdto> findall(string sp)
        {
           return ctddhrp.Find(c => c.sanpham.tensp.Contains(sp)).Take(10).Select(c => new chitietdondathangdto(c)).ToList();
        }
        /*
        public List<chitietdondathangdto> list()
        {
            return ctddhrp.GetAll().Select(c => new chitietdondathangdto(c)).ToList();
        }
        */
        public List<chitietdondathangdto> listdanhsachdangcho()
        {
            return ctddhrp.Find(c => c.trangthai == "Chưa giao").Select(c => new chitietdondathangdto(c)).ToList();
        }

        public bool capnhattrangthai(int madon, int stt, int trangthai, int soluongmoi = 0)
        {
            chitietdondathang ctddh = ctddhrp.First(c => c.madondathang == madon && c.stt == stt);
            int? slnhancu = ctddh.soluongnhan;
            sanphamcontroller spc = new sanphamcontroller();
            if (trangthai == 0)
            {
                spc.capnhatsoluong(ctddh.id, slnhancu);
                ctddh.soluongnhan = 0;
                ctddh.trangthai = "Chưa giao";
                ctddh.tinhtrang = "Đang chờ";
            }
            else if (trangthai == 1)
            {
                int? sltangthem = ctddh.soluongdat - slnhancu;
                spc.capnhatsoluongton(ctddh.id, sltangthem);
                ctddh.trangthai = "Đã hoàn tất";
                ctddh.tinhtrang = "Kết thúc";
                ctddh.soluongnhan = ctddh.soluongdat;
            }
            else if (trangthai == 2)
            {
                if (ctddh.soluongnhan > 0) spc.capnhatsoluong(ctddh.id, ctddh.soluongnhan);
                ctddh.trangthai = "Hủy";
                ctddh.tinhtrang = "Kết thúc";
                ctddh.soluongnhan = 0;
            }
            else if (trangthai == 3)
            {
                int? sltangthem = soluongmoi - slnhancu;
                if (soluongmoi > 0) spc.capnhatsoluongton(ctddh.id, soluongmoi);
                ctddh.trangthai = "Thiếu hàng";
                ctddh.soluongnhan = soluongmoi;
            }
            return ctddhrp.Update(ctddh);
        }

        /*
        public bool capnhattinhtrang(int madon, int stt, int tinhtrang)
        {
            chitietdondathang ctddh = ctddhrp.First(c => c.madondathang == madon && c.stt == stt);
            if (tinhtrang == 0)
            {
                ctddh.tinhtrang = "Kết thúc";
            }
            else if (tinhtrang == 1)
                ctddh.tinhtrang = "Đang chờ";
            return ctddhrp.Update(ctddh);
        }
        public bool update(chitietdondathang entity)
        {
            if (entity.stt != 0)
            {
                if (validate(entity))
                {
                    return ctddhrp.Attach(entity);
                }
            }
            return false;
        }

        public bool delete(chitietdondathang entity)
        {
            return ctddhrp.Delete(entity);
        }
         */
    }
}
