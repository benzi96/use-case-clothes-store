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
    public partial class ThemsanphamF : Form
    {
        public ThemsanphamF()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            sizecb.SelectedItem = "S";
            ngaynhapsplb.Text = DateTime.Now.ToString();
        }
        sanphamcontroller spcontroller = new sanphamcontroller();

        #region event
        //Nút lưu (check hợp lệ)(x)
        private void luuspbtn_Click(object sender, EventArgs e)
        {
            if (kiemtrahople())
            {
                thongbao(add());
                this.ActiveControl = masptxt;
                masptxt.Select(0, masptxt.Text.Length);
            }
        }

        //Hàm add(x)
        private bool add()
        {
            sanpham sp = new sanpham();
            sp.masp = masptxt.Text;
            sp.tensp = tensptxt.Text;
            sp.size = sizecb.SelectedItem.ToString();
            sp.soluongtonkho = Convert.ToInt16(soluongnud.Value);
            sp.hang = nhacctxt.Text;
            sp.giaban = giabannud.Value;
            sp.giamgia = 0;
            sp.ngaynhap = Convert.ToDateTime(ngaynhapsplb.Text);
            return spcontroller.add(sp);
        }

        //nút hủy(x)
        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //tắt thông báo(x)
        private void anthongbao_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }
        #endregion

        #region ham private 
        //check thông tin nhập(x)
        private bool kiemtrahople()
        {
            int loi = 0;
            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        loi++;
                        errorProvider1.SetError(c, "Bạn phải điền đầy đủ thông tin!");
                    }
                }
                if (c is NumericUpDown)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        loi++;
                        errorProvider1.SetError(c, "Bạn phải điền đầy đủ thông tin!");
                    }
                }
            }
            if(loi == 0)
                return true;
            return false;
        }

        //thông báo nhập thành công hay thất bại (x)
        private void thongbao(bool thanhcong)
        {
            splitContainer1.Panel1Collapsed = false;
            if (thanhcong)
            {
                baothemthatbaibtn.Visible = false;
                baothemthanhcongbtn.Visible = true;
            }
            else
            {
                baothemthatbaibtn.Visible = true;
                baothemthanhcongbtn.Visible = false;
            }
        }

        //Highlight textbox soluongnud(x)
        private void soluongnud_Enter(object sender, EventArgs e)
        {
            soluongnud.Select(0, soluongnud.Text.Length);
        }

        //Highlight textbox giabannud(x)
        private void giabannud_Enter(object sender, EventArgs e)
        {
            giabannud.Select(0, giabannud.Text.Length);
        }
        #endregion
    }
}
