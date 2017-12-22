using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1.boundary
{
    public class common
    {
        //báo lỗi khi bị lỗi add, update, delete
        public static void successorerror(bool b)
        {
            if (b)
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Lỗi");
        }

        public static void successorerror(int b)
        {
            if (b == 1)
                MessageBox.Show("Thành công");
            else
                if (b == 0)
                    MessageBox.Show("Lỗi");
                else if (b == -1)
                    MessageBox.Show("Bạn phải có quyền admin để xóa!");
        }


        //clear tất cả textbox, checkbox, radiobutton, picturebox
        public static void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                if (c is PictureBox)
                    ((PictureBox)c).Image = null;
            }
        }
        public static void ClearOnlyTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearOnlyTextBoxes(c);
                }

            }
        }


        //copy vo clipboard
        public static void copyAlltoClipboard(DataGridView dgv)
        {
            //to remove the first blank column from datagridview
            dgv.RowHeadersVisible = false;
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        public static void xuatexcel(DataGridView dgv)
        {
            //copyAlltoClipboard(dgv);
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        //kt số nếu không phải return 0
        public static int ktint(string so)
        {
            int a = 0;
            if (int.TryParse(so, out a))
            {
                return a;
            }
            return 0;
        }
        public static decimal ktdecimal(string so)
        {
            decimal b = 0;
            if (decimal.TryParse(so, out b))
            {
                return b;
            }
            return 0;
        }

        private bool kiemtraemptynull(Panel p, ErrorProvider e)
        {
            int loi = 0;
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        loi++;
                        e.SetError(c, "Bạn phải điền đầy đủ thông tin!");
                    }
                }
                if (c is NumericUpDown)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        loi++;
                        e.SetError(c, "Bạn phải điền đầy đủ thông tin!");
                    }
                }
            }
            if (loi == 0)
                return true;
            return false;
        }
    }
}
