using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.controller
{
    public class sanphamcontroller
    {
        public IRepository<sanpham> sprp;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public sanphamcontroller()
        {
            sprp = new GenericRepository<sanpham>();
        }
        /*
        public bool validate(sanpham entity)
        {
            if (entity.masp.Trim().Length == 0) validatedictionary.Add("MASP", "Không được để trống mã sản phẩm");
            if (entity.tensp.Trim().Length == 0) validatedictionary.Add("TENSP", "Không được để trống tên sản phẩm");
                return true;
            return false;
        }
         */

        //(x)
        private static IEnumerable<sanpham> ApplyAndPredicates(IEnumerable<Func<sanpham, bool>> predicates, IEnumerable<sanpham> sp)
        {
            var filteredsp = sp;
            foreach (var predicate in predicates)
            {
                filteredsp = filteredsp.Where(predicate);
            }
            return filteredsp;
        }
        //(x)
        public List<sanphamdto> MeetCriteria(int? soluong = null, string size = null, DateTime? ngaynhap = null,DateTime? ngaynhapden = null,decimal? giabantu=null,decimal? giabanden=null,string hang = null)
        {
            var sp = sprp.GetAll();
            var predicates = new List<Func<sanpham, bool>>();
            if (soluong.HasValue && soluong == 0)
            {
                predicates.Add(s => s.soluongtonkho == 0);
            }
            else if(soluong.HasValue && soluong == 1)
            {
                predicates.Add(s => s.soluongtonkho > 0);
            }
            if (size != null)
            {
                predicates.Add(s => s.size == size);
            }
            if (ngaynhap != null)
            {
              predicates.Add(s => (s.ngaynhap >= ngaynhap));
            }
            if (giabantu != null && giabanden != null)
            {
                predicates.Add(s => (s.giaban >= giabantu && s.giaban <= giabanden)); 
            }
            if (hang != null)
            {
                predicates.Add(s => s.hang == hang);
            }
            return ApplyAndPredicates(predicates, sp).Select(c=>new sanphamdto(c)).ToList();
        }

        //(xx)
        public string laytensp(string masp)
        {
            return sprp.First(c => c.masp == masp).tensp;
        }

        //(xx)
        public int layidsp(string masp)
        {
            return sprp.Find(c => c.masp == masp).Select(c => c.id).FirstOrDefault();
        }

        //(x)
        public int layidsptheoten(string tensp)
        {
            return sprp.Find(c => c.tensp == tensp).Select(c => c.id).FirstOrDefault();
        }
   
        //(xx)
        public decimal? laygiaban(string masp)
        {
            return sprp.Find(c => c.masp == masp).Select(c => c.giaban).FirstOrDefault();
        }
        
        //(xx)
        public List<string> laydanhsachmasp()
        {
            return sprp.GetAll().Select(c => c.masp).ToList();
        }

        //(x)
        public List<string> laydanhsachtensp()
        {
            return sprp.GetAll().Select(c => c.tensp).ToList();
        }
        
        //(xx)
        public bool ktidtontai(string id)
        {
            return sprp.GetQuery().Any(c => c.masp == id);
        }

        public bool kttensptontai(string ten)
        {
            return sprp.GetQuery().Any(c => c.tensp == ten);
        }
        //(xx)
        public bool ktsoluong(string masp,int sl)
        {
            sanpham sp = sprp.First(c => c.masp == masp);
            if(sp.soluongtonkho< sl)
            {
                return false;
            }
            return true;
        }
        /*
        public List<sanphamdto> find(string masp)
        {
            return sprp.Find(c => c.masp == masp).Select(c=> new sanphamdto(c)).ToList();
        }
         */
        //(x)
        public List<sanphamdto> findall(string sp)
        {
            return sprp.Find(c => c.masp.Contains(sp) || c.tensp.Contains(sp)).Take(10).Select(c => new sanphamdto(c)).ToList();
        }
        //(x)
        public List<sanphamdto> list()
        {
            return sprp.GetAll().Select(c => new sanphamdto(c)).ToList();
        }
        //(x)
        public bool add(sanpham entity)
        {
            //if (validate(entity))
            //{
                if (ktidtontai(entity.masp))
                {
                    validatedictionary.Add("MASP", "Mã sản phẩm trùng");
                }
                else
                    return sprp.Add(entity);
            //}
           return false;
        }
        //(xx)
        public bool capnhatsoluong(int id, int? sl)
        {
            sanpham entity = sprp.First(c => c.id == id);
            entity.soluongtonkho -= sl;
            return sprp.Update(entity);
        }

        public List<sanpham> laytatca()
        {
            return sprp.GetAll().ToList();
        }
        //(x)
        public bool capnhatsoluongton(int id, int? sl)
        {
            sanpham entity = sprp.First(c => c.id == id);
            entity.soluongtonkho += sl;
            return sprp.Update(entity);
        }
       /*
        public bool update(sanpham entity)
        {
            if (validate(entity))
                return sprp.Attach(entity);
           return false;
        }
        public bool delete(sanpham entity)
        {
                return sprp.Delete(entity); 
        }
        */ 
    }
}
