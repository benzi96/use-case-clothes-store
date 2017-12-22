using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.controller;
using WindowsFormsApplication1.entity;

namespace WindowsFormsApplication1.boundary
{
    public partial class KiemKeDonHangF : Form
    {
        chitietdondathangcontroller ctddhcontroller = new chitietdondathangcontroller();
        public KiemKeDonHangF()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        #region event va public
        //lấy danh sách đơn đặt hàng (x)
        public void laydanhsachdonhang()
        {
            donhangdgv.DataSource = ctddhcontroller.listdanhsachdangcho();
            dieuchinhtable();
        }

        //show panel tìm kiếm nâng cao(x)
        private void timkiemnangcaobtn_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
                splitContainer1.Panel1Collapsed = true;
            else splitContainer1.Panel1Collapsed = false;
        }

        //nút thoát (x)
        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nút lọc thông tin(x)
        private void locbtn_Click(object sender, EventArgs e)
        {
            int? madon = null;
            string tensanpham = null;
            int? soluongdat = null;
            int? soluongnhan = null;
            string trangthai = null;
            DateTime? ngaydat = null;
            DateTime? ngaydatden = null;
            if (checkBox1.Checked) madon = Int32.Parse(textBox1.Text);
            if (checkBox2.Checked) soluongdat = Int32.Parse(soluongdattxt.Value.ToString());
            if (checkBox3.Checked) tensanpham = textBox2.Text;
            if (checkBox5.Checked) trangthai = comboBox2.SelectedItem.ToString();
            if (checkBox7.Checked) soluongnhan = Int32.Parse(soluongnhantxt.Value.ToString());
            if (checkBox4.Checked)
            {
                ngaydat = dateTimePicker1.Value.Date;
                ngaydatden = dateTimePicker1.Value.Date.AddDays(1);
            }
            donhangdgv.DataSource = ctddhcontroller.MeetCriteria(madon, soluongdat, soluongnhan, tensanpham, trangthai, ngaydat, ngaydatden);
            dieuchinhtable();
        }

        //tìm sản phẩm trong các đơn đặt hàng(x)
        private void timkiemtxt_TextChanged(object sender, EventArgs e)
        {
            donhangdgv.DataSource = ctddhcontroller.findall(timkiemtxt.Text);
            dieuchinhtable();
        }

        //(x)
        private void capnhattrangthai(int trangthai)
        {
            if (donhangdgv.SelectedRows.Count > 0)
            {
                int loi = 0;
                foreach (DataGridViewRow row in donhangdgv.SelectedRows)
                {
                    int maddh = Convert.ToInt16(row.Cells[0].Value.ToString());
                    int stt = Convert.ToInt16(row.Cells[1].Value.ToString());
                    if(!ctddhcontroller.capnhattrangthai(maddh, stt, trangthai)) loi++;
                }
                if (loi > 0) MessageBox.Show("Xảy ra lỗi khi cập nhật!");
                else common.successorerror(true);
                laydanhsachdonhang();
            }
            else MessageBox.Show("Chưa chọn đơn đặt hàng cần cập nhật!");
        }
        //(x)
        private void khoiphucbtn_Click(object sender, EventArgs e)
        {
            capnhattrangthai(0);
        }
        //(x)
        private void capnhatsoluongdubtn_Click(object sender, EventArgs e)
        {
            capnhattrangthai(1);
        }
        //(x)
        private void huybtn_Click(object sender, EventArgs e)
        {
            capnhattrangthai(2);
        }
        //(x)
        private void donhangdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (donhangdgv.Columns[e.ColumnIndex].HeaderText == "Số lượng nhận")
            {
                //int columnIndex = donhangdgv.CurrentCell.ColumnIndex + 2;
                //int rowIndex = donhangdgv.CurrentCell.RowIndex;
                int sl = common.ktint(donhangdgv.CurrentCell.Value.ToString());
                donhangdgv.CurrentCell.Value = sl;
                int sldat = Convert.ToInt16(donhangdgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value);
                if (sl < sldat)
                {
                    donhangdgv.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = "Thiếu hàng";
                    int maddh = Convert.ToInt16(donhangdgv.Rows[e.RowIndex].Cells[0].Value);
                    int stt = Convert.ToInt16(donhangdgv.Rows[e.RowIndex].Cells[1].Value);
                    common.successorerror(ctddhcontroller.capnhattrangthai(maddh, stt, 3, sl));
                }
                else if (sl == sldat) capnhattrangthai(1);

            }
        }
        #endregion

        #region ham private
        //Chỉnh width table(x)
        private void dieuchinhtable()
        {
            donhangdgv.Columns[0].Width = 100;
            donhangdgv.Columns[1].Width = 125;
            donhangdgv.Columns[2].Width = 120;
            donhangdgv.Columns[4].Width = 123;
            donhangdgv.Columns[5].Width = 120;
            donhangdgv.Columns[6].Width = 120;
        }
        #endregion
    }
}
