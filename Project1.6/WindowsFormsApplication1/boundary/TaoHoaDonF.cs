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
    public partial class TaoHoaDonF : Form
    {
        public TaoHoaDonF()
        {
            InitializeComponent();
        }

        sanphamcontroller spcontroller = new sanphamcontroller();
        hoadoncontroller hdc = new hoadoncontroller();

        #region event va public
        //cập nhật ngày bán và mã hóa đơn khi bấm lưu và khi load form(x)
        public void capnhatmangayban()
        {
            ngayban.Text = DateTime.Now.ToString();
            maHD.Text = (hdc.getcurrentid() + 1).ToString();
        }

        //làm mới form(x)
        private void clearform()
        {
            masptxt.Clear();
            soluongtxt.Value = 1;
            HDtable.Rows.Clear();
            capnhatmangayban();
        }

        //autocomplete textbox mã sản phẩm(x)
        public void goiymasp()
        {
            List<string> masp = spcontroller.laydanhsachmasp();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            coll.AddRange(masp.ToArray());
            masptxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            masptxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            masptxt.AutoCompleteCustomSource = coll;
        }

        //Event click button thêm(x)
        private void thembtnTHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masptxt.Text) || string.IsNullOrWhiteSpace(soluongtxt.Value.ToString()))
            {
                errorProvider1.SetError(masptxt, "Bạn phải điền đủ thông tin!");               
            }
            if (string.IsNullOrWhiteSpace(soluongtxt.Value.ToString()))
            {
                errorProvider1.SetError(soluongtxt, "Bạn phải điền đủ thông tin!");
            }
            else
            {
                int sl = Convert.ToInt32(soluongtxt.Value);
                if (!spcontroller.ktsoluong(masptxt.Text, sl))
                {
                    MessageBox.Show("Số lượng tồn kho không đủ!");
                }
                else
                {
                    HDtable.Rows.Add(masptxt.Text, spcontroller.laytensp(masptxt.Text), soluongtxt.Value, spcontroller.laygiaban(masptxt.Text), soluongtxt.Value * spcontroller.laygiaban(masptxt.Text));
                    tinhtong();
                }
            }
        }

        //Highlight soluongtxt và lấy giá bán(x)
        private void soluongtxt_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masptxt.Text) == true)
            {
                MessageBox.Show("không được để trống mã sản phẩm");
                this.ActiveControl = masptxt;
            }
            else if (!spcontroller.ktidtontai(masptxt.Text))
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                this.ActiveControl = masptxt;
            }
            else
            {
                soluongtxt.Select(0, soluongtxt.Text.Length);
                masptxt.Text = masptxt.Text.ToUpper();
            }
         }

        //Event click button lưu(x)
        private void LuubtnTHD_Click(object sender, EventArgs e)
        {
            Decimal tongcongHD = Decimal.Parse(tongcongHDtxtTHD.Text);
            if (string.IsNullOrWhiteSpace(tienkhachduatxt.Text))
            {
                errorProvider1.SetError(tienkhachduatxt, "Bạn phải nhập đủ thông tin!");
            }

            else
            {
                Decimal tienkhachdua = Decimal.Parse(tienkhachduatxt.Text);
                if (tienkhachdua < tongcongHD)
                {
                    MessageBox.Show("Tiền khách trả không đủ");
                }
                else
                {
                    hoadon hd = new hoadon();
                    hd.ngayban = Convert.ToDateTime(ngayban.Text);
                    hd.tienkhachdua = Decimal.Parse(tienkhachduatxt.Text);
                    for (int i = 0; i < HDtable.RowCount - 1; i++)
                    {
                        chitiethoadon cthd = new chitiethoadon();
                        cthd.stt = i + 1;
                        cthd.mahoadon = hd.mahoadon;
                        cthd.id = spcontroller.layidsp(HDtable.Rows[i].Cells[0].Value.ToString());
                        cthd.giaban = Decimal.Parse(HDtable.Rows[i].Cells[3].Value.ToString());
                        cthd.soluongmua = Int32.Parse(HDtable.Rows[i].Cells[2].Value.ToString());
                        hd.chitiethoadons.Add(cthd);
                    }
                    bool success = hdc.add(hd);
                    if (success == true)
                    {
                        MessageBox.Show("Lưu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bai");
                    }
                    clearform();
                }
            }
        }

        //Event click button hủy(x)
        private void huybtnTHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sửa số lượng trong table(x)
        private void HDtable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (HDtable.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                int columnIndex = HDtable.CurrentCell.ColumnIndex + 2;
                int rowIndex = HDtable.CurrentCell.RowIndex;
                int sl = common.ktint(HDtable.CurrentCell.Value.ToString());
                decimal dongia = Convert.ToDecimal(HDtable.Rows[rowIndex].Cells[columnIndex - 1].Value);
                HDtable.Rows[rowIndex].Cells[columnIndex].Value = sl * dongia;
                tinhtong();
            }
        }

        //menu ngữ cảnh(x)
        private void HDtable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Xóa",null,new EventHandler(xoa));
                    //Di chuyen den dong hien hanh
                    HDtable.CurrentCell = HDtable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = HDtable.PointToClient(Control.MousePosition);
                    menu.Show(HDtable, pt.X, pt.Y);
                }
            }
        }

        //tính tiền thừa
        private void tienkhachduatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (tongcongHDtxtTHD.Text != null && tienkhachduatxt.Text != null)
                {
                    int tonghoadon = Int32.Parse(tongcongHDtxtTHD.Text);
                    int tienkhachtra = Int32.Parse(tienkhachduatxt.Text);
                    int tienthua = tienkhachtra - tonghoadon;
                    if (tienthua >= 0)
                        tienthuatxt.Text = tienthua.ToString();
                    else
                        MessageBox.Show("Tiền khách đưa không đủ!");
                }
            }
        }

        //hàm xóa cho menu ngữ cảnh(x)
        private void xoa(object sender, EventArgs args)
        {
            HDtable.Rows.RemoveAt(HDtable.CurrentRow.Index);
        }

        #endregion

        #region ham private
        //tính tổng hóa đơn(x)
        private void tinhtong()
        {
            int tong = 0;
            for (int i = 0; i < HDtable.RowCount - 1; i++)
            {
                tong += Int32.Parse(HDtable.Rows[i].Cells[4].Value.ToString());
            }
            tongcongHDtxtTHD.Text = tong.ToString();
            cleartext();
            this.ActiveControl = masptxt;
        }

        //làm mới để thêm tiếp(x)
        private void cleartext()
        {
            masptxt.Clear();
            soluongtxt.Value = 1;
        }

        #endregion
    }
}
