using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApplication1.controller;

namespace WindowsFormsApplication1.boundary
{
    public partial class ThongKeF : Form
    {
        public ThongKeF()
        {
            InitializeComponent();
        }
        chitiethoadoncontroller cthdcontroller = new chitiethoadoncontroller();
        hoadoncontroller hdcontroller = new hoadoncontroller();

        #region event va public
        public void doanhthuhomnay()
        {
            hdtable.DataSource = hdcontroller.doanhthuhomnay();
        }
        //(x)
        private void thongkespbtn_Click(object sender, EventArgs e)
        {
            DateTime tungay;
            DateTime denngay;
            if( tungaysp.Value.Date <= denngaysp.Value.Date )
            {
                tungay = tungaysp.Value.Date;
                denngay = denngaysp.Value.AddDays(1);
                sptable.DataSource = cthdcontroller.timdethongke(tungay, denngay);
                sptable.Columns[1].Width = 80;
                sptable.Columns[2].Width = 90;
                sptable.Columns[3].Width = 175;
                sptable.Columns[5].Width = 120;
                sptable.Columns[6].Width = 120;
            }
            else
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }           
        }
        //(x)
        private void thongkedtbtn_Click(object sender, EventArgs e)
        {
            DateTime tungay;
            DateTime denngay;
            if (tungayhd.Value.Date <= denngayhd.Value.Date)
            {
                tungay = tungayhd.Value.Date;
                denngay = denngayhd.Value.AddDays(1);
                hdtable.DataSource = hdcontroller.timdethongke(tungay, denngay);
                hdtable.Columns[0].Width = 75;
                hdtable.Columns[1].Width = 120;
                hdtable.Columns[2].Width = 75;
            }
            else
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }
            if (hdtable.DataSource != null)
            {
                int tongcong = 0;
                for (int i = 0; i < hdtable.RowCount; i++)
                {
                    tongcong += Int32.Parse(hdtable.Rows[i].Cells[2].Value.ToString());
                }
                tongcongtxt.Text = tongcong.ToString();
            }
            else
            {
                tongcongtxt.Text = "0";
            }
        }

        private void thoatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tknhieuit(int luachon)
        {
            DateTime tungay;
            DateTime denngay;
            if (tungaysp.Value.Date <= denngaysp.Value.Date)
            {
                tungay = tungaysp.Value.Date;
                denngay = denngaysp.Value.AddDays(1);
                if (luachon == 0)
                    sptable.DataSource = cthdcontroller.soluongbanranhieunhat(tungay, denngay);
                if (luachon == 1)
                    sptable.DataSource = cthdcontroller.soluongbanraitnhat(tungay, denngay);
                if (luachon == 2)
                    sptable.DataSource = cthdcontroller.doanhthubanranhieunhat(tungay, denngay);
                if (luachon == 3)
                    sptable.DataSource = cthdcontroller.doanhthubanraitnhat(tungay, denngay);
            }
            else
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }
        }
        //(x)
        private void bannhiunhatbtn_Click(object sender, EventArgs e)
        {

            tknhieuit(0);
        }
        //(x)
        private void banitnhatbtn_Click(object sender, EventArgs e)
        {
            tknhieuit(1);
        }
        //(x)
        private void doanhthucaonhatbtndoanhthucaonhatbtn_Click(object sender, EventArgs e)
        {
            tknhieuit(2);
        }
        //(x)
        private void doanhthuthapnhatbtn_Click(object sender, EventArgs e)
        {
            tknhieuit(3);
        }
        //(x)
        private void tktheonambtn_Click(object sender, EventArgs e)
        {
            Axis XA = chart1.ChartAreas[0].AxisX;
            Axis YA = chart1.ChartAreas[0].AxisY;
            Series S1 = chart1.Series[0];

            List<DateTime> dates = new List<DateTime>();
            DateTime dt = DateTime.Now;
            for (int i = 1; i <= 12; i++)
                dates.Add(new DateTime(dt.Year, i, 1));

            int y = 1;
            foreach (DateTime d in dates)
            {
                chart1.Series[0].Points.AddXY(d, cthdcontroller.doanhthutheothang(y, Convert.ToInt32(namunud.Value)));
                y++;
            }
            
            // show the year in the legend:
            S1.LegendText = "Năm " + dt.Year;
            // move to the bottom center:
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;

            chart1.Series[0].XValueType = ChartValueType.Date;


            XA.MajorGrid.Enabled = false;         // no gridlines
            XA.LabelStyle.Format = "MMM";         // show months as names

            XA.IntervalType = DateTimeIntervalType.Months;  // show axis labels.. 
            XA.Interval = 1;

            YA.LabelStyle.Format = "##0$";  // for kilos etc you need to scale the y-values!
            if (y == 12) y = 1;
        }
        #endregion

    }
}
