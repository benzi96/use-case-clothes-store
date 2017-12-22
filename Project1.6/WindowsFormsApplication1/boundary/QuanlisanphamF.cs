using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.controller;

namespace WindowsFormsApplication1.boundary
{
    public partial class QuanlisanphamF : Form
    {
        sanphamcontroller spcontroller = new sanphamcontroller();
        public QuanlisanphamF()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        #region event
        //Thêm sản phẩm mới(x)
        private void themsanphambtn_Click(object sender, EventArgs e)
        {
            ThemsanphamF themsanphamform = new ThemsanphamF();
            themsanphamform.Show();
        }

        //load danh sách sản phẩm lên table(x)
        public void laydanhsachsanpham()
        {
            danhsachspdgv.DataSource = spcontroller.list();
            dieuchinhtable();
        }

        //show panel tìm nâng cao(x)
        private void timkiemnangcaobtn_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
                splitContainer1.Panel1Collapsed = true;
            else splitContainer1.Panel1Collapsed = false;
        }

        //nút thoát(x)
        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //tìm kiếm mã sp hoặc tên sp(x)
        private void timkiemtxt_TextChanged(object sender, EventArgs e)
        {
            danhsachspdgv.DataSource = spcontroller.findall(timkiemtxt.Text);
            dieuchinhtable();
        }

        //Nút lọc thông tin(x)
        private void locbtn_Click(object sender, EventArgs e)
        {
            int? soluong = null;
            string size = null;
            DateTime? ngaynhap = null;
            DateTime? ngaynhapden = null;
            decimal? giabantu = null;
            decimal? giabanden = null;

            string hang = null;
            if (checkBox1.Checked && radioButton1.Checked) soluong = 0;
            if (checkBox1.Checked && radioButton2.Checked) soluong = 1;
            if (checkBox2.Checked) size = comboBox1.SelectedItem.ToString();
            if (checkBox5.Checked) hang = textBox1.Text;
            if (checkBox3.Checked)
            {
                ngaynhap = dateTimePicker1.Value.Date;
                //ngaynhapden = dateTimePicker1.Value.Date.AddDays(1);
            }
            if (checkBox4.Checked)
            {
                if (giabantutxt.Value <= giabandentxt.Value)
                {
                    giabantu = giabantutxt.Value;
                    giabanden = giabandentxt.Value;
                }
                else
                {
                    MessageBox.Show("Giá nhập không hợp lệ");
                }
            }

            danhsachspdgv.DataSource = spcontroller.MeetCriteria(soluong, size, ngaynhap, ngaynhapden, giabantu, giabanden, hang);
            dieuchinhtable();
            clearradiobutton();
        }
        //(x)
        private void capnhatbtn_Click(object sender, EventArgs e)
        {
            int id = spcontroller.layidsp(masplbl.Text);
            int? soluongton = Convert.ToInt32(soluongmoinud.Value);
            common.successorerror(spcontroller.capnhatsoluongton(id, soluongton));
        }
        //(x)
        private void danhsachspdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                masplbl.Text = danhsachspdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                soluongmoinud.Value = Convert.ToDecimal(danhsachspdgv.Rows[e.RowIndex].Cells[6].Value);
            }
        }
        #endregion

        #region ham private
        //chỉnh width table(x)
        private void dieuchinhtable()
        {
            danhsachspdgv.Columns[0].Width = 60;
            danhsachspdgv.Columns[1].Width = 100;
            danhsachspdgv.Columns[2].Width = 140;
            danhsachspdgv.Columns[3].Width = 77;
            danhsachspdgv.Columns[4].Width = 90;
            danhsachspdgv.Columns[5].Width = 100;
            danhsachspdgv.Columns[6].Width = 100;
            danhsachspdgv.Columns[7].Width = 138;
        }

        //clear radiobutton(x)
        private void clearradiobutton()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        //Hightlight textbox(xx)
        private void giabantutxt_Enter(object sender, EventArgs e)
        {
            giabantutxt.Select(0, giabantutxt.Text.Length);
        }

        //Hightlight textbox(x)
        private void giabandentxt_Enter(object sender, EventArgs e)
        {
            giabandentxt.Select(0, giabandentxt.Text.Length);
        }
        #endregion
    }
}
