using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.boundary
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            cuahangEntities ch = new cuahangEntities();
            if (!ch.DatabaseExists()) MessageBox.Show("Database không tồn tại!");
        }

        private void taohoadonbtn_Click(object sender, EventArgs e)
        {
            TaoHoaDonF taohoadonform = new TaoHoaDonF();
            taohoadonform.Show();
            taohoadonform.capnhatmangayban();
            taohoadonform.goiymasp();
        }

        private void quanlisanphambtn_Click(object sender, EventArgs e)
        {
            QuanlisanphamF quanlisanphamform = new QuanlisanphamF();
            quanlisanphamform.Show();
            quanlisanphamform.laydanhsachsanpham();
        }

        private void thongkebtn_Click(object sender, EventArgs e)
        {
            ThongKeF thongkeform = new ThongKeF();
            thongkeform.Show();
            thongkeform.doanhthuhomnay();
        }

        private void taodondathangbtn_Click(object sender, EventArgs e)
        {
            TaoDonDatHangF taodondathangform = new TaoDonDatHangF();
            taodondathangform.Show();
            taodondathangform.capnhatmangaytao();
            taodondathangform.goiytensp();
        }

        private void kiemkedonhangbtn_Click(object sender, EventArgs e)
        {
            KiemKeDonHangF kiemkeform = new KiemKeDonHangF();
            kiemkeform.Show();
            kiemkeform.laydanhsachdonhang();
        }

    }
}
