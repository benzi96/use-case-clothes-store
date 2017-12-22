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
    public partial class TaoDonDatHangF : Form
    {
        public TaoDonDatHangF()
        {
            InitializeComponent();
            this.ActiveControl = tensptxt;
        }

        dondathangcontroller ddhc = new dondathangcontroller();
        sanphamcontroller spcontroller = new sanphamcontroller();

        #region event va public
        //cập nhật ngày tạo và mã đơn khi bấm lưu và khi load form(xx)
        public void capnhatmangaytao()
        {
            ngaytao.Text = DateTime.Now.ToString();
            madontxt.Text = (ddhc.getcurrentid() + 1).ToString();
        }

        //autocomplete textbox tên sản phẩm(xx)
        public void goiytensp()
        {
            List<string> tensp = spcontroller.laydanhsachtensp();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            coll.AddRange(tensp.ToArray());
            tensptxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tensptxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tensptxt.AutoCompleteCustomSource = coll;
        }

        //làm mới form(xx)
        private void clearform()
        {
            nhacungcaptxt.Clear();
            soluongtxt.Value = 1;
            tensptxt.Clear();
            dondathangtable.Rows.Clear();
            capnhatmangaytao();
        }

        //Event click button thêm(xx)
        private void thembtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tensptxt.Text))
            {
                errorProvider1.SetError(tensptxt, "Bạn phải điền đầy đủ thông tin!");
            }
            if (string.IsNullOrWhiteSpace(soluongtxt.Value.ToString()))
            {
                errorProvider1.SetError(soluongtxt, "Bạn phải điền đầy đủ thông tin!");
            }
            if (string.IsNullOrWhiteSpace(nhacungcaptxt.Text))
            {
                errorProvider1.SetError(nhacungcaptxt, "Bạn phải điền đầy đủ thông tin!");
            }
            else
            {
                dondathangtable.Rows.Add(tensptxt.Text, nhacungcaptxt.Text, soluongtxt.Value,"Chưa giao");
                cleartext();
                this.ActiveControl = tensptxt;
            }
        }

        //Event click button lưu(xx)
        private void luubtn_Click(object sender, EventArgs e)
        {
            dondathang ddh = new dondathang();
            ddh.ngaydathang = Convert.ToDateTime(ngaytao.Text);
            ddh.nhacungcap = nhacungcaptxt.Text;
            for (int i = 0; i < dondathangtable.RowCount - 1; i++)
            {
                chitietdondathang ctddh = new chitietdondathang();
                
                ctddh.stt = i + 1;
                ctddh.madondathang = ddh.madondathang;
                ctddh.id = spcontroller.layidsptheoten(dondathangtable.Rows[i].Cells[0].Value.ToString());
                ctddh.soluongdat = Int32.Parse(dondathangtable.Rows[i].Cells[2].Value.ToString());
                ctddh.soluongnhan = 0;
                ctddh.trangthai = dondathangtable.Rows[i].Cells[3].Value.ToString();
                ddh.chitietdondathangs.Add(ctddh);
            }
            bool success;
            success = ddhc.add(ddh);
            common.successorerror(success);
            clearform();      
        }

        //Event click button hủy(xx)
        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Highlight soluongtxt(xx)
        private void soluongtxt_Enter(object sender, EventArgs e)
        {
            if (!spcontroller.kttensptontai(tensptxt.Text))
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
            }
            soluongtxt.Select(0, soluongtxt.Text.Length);
        }

        private void dondathangtable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Xóa", null, new EventHandler(xoa));
                    //Di chuyen den dong hien hanh
                    dondathangtable.CurrentCell = dondathangtable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = dondathangtable.PointToClient(Control.MousePosition);
                    menu.Show(dondathangtable, pt.X, pt.Y);
                }
            }
        }

        //hàm xóa cho menu ngữ cảnh(x)
        private void xoa(object sender, EventArgs args)
        {
            dondathangtable.Rows.RemoveAt(dondathangtable.CurrentRow.Index);
        }
        #endregion

        #region ham private
        //làm mới để thêm tiếp(xx)
        private void cleartext()
        {
            soluongtxt.Value = 1;
            tensptxt.Clear();
        }
        #endregion
    }
}
