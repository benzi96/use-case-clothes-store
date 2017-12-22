namespace WindowsFormsApplication1.boundary
{
    partial class TaoDonDatHangF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dondathangtable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thembtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.soluongtxt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tensptxt = new System.Windows.Forms.TextBox();
            this.ngaytao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.huybtn = new System.Windows.Forms.Button();
            this.luubtn = new System.Windows.Forms.Button();
            this.madontxt = new System.Windows.Forms.Label();
            this.nhacungcaptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dondathangtable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dondathangtable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ngaytao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.huybtn);
            this.panel1.Controls.Add(this.luubtn);
            this.panel1.Controls.Add(this.madontxt);
            this.panel1.Controls.Add(this.nhacungcaptxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 444);
            this.panel1.TabIndex = 1;
            // 
            // dondathangtable
            // 
            this.dondathangtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dondathangtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tensp,
            this.NCC,
            this.SL,
            this.TrangThai});
            this.dondathangtable.Location = new System.Drawing.Point(12, 165);
            this.dondathangtable.Name = "dondathangtable";
            this.dondathangtable.Size = new System.Drawing.Size(725, 237);
            this.dondathangtable.TabIndex = 36;
            this.dondathangtable.TabStop = false;
            this.dondathangtable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dondathangtable_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.thembtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.soluongtxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tensptxt);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 68);
            this.panel2.TabIndex = 35;
            // 
            // thembtn
            // 
            this.thembtn.Location = new System.Drawing.Point(576, 28);
            this.thembtn.Name = "thembtn";
            this.thembtn.Size = new System.Drawing.Size(132, 23);
            this.thembtn.TabIndex = 5;
            this.thembtn.Text = "Thêm vào đơn đặt hàng";
            this.thembtn.UseVisualStyleBackColor = true;
            this.thembtn.Click += new System.EventHandler(this.thembtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên sản phẩm";
            // 
            // soluongtxt
            // 
            this.soluongtxt.Location = new System.Drawing.Point(378, 31);
            this.soluongtxt.Name = "soluongtxt";
            this.soluongtxt.Size = new System.Drawing.Size(133, 20);
            this.soluongtxt.TabIndex = 3;
            this.soluongtxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.soluongtxt.Enter += new System.EventHandler(this.soluongtxt_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số lượng đặt";
            // 
            // tensptxt
            // 
            this.tensptxt.Location = new System.Drawing.Point(24, 31);
            this.tensptxt.Name = "tensptxt";
            this.tensptxt.Size = new System.Drawing.Size(281, 20);
            this.tensptxt.TabIndex = 2;
            // 
            // ngaytao
            // 
            this.ngaytao.AutoSize = true;
            this.ngaytao.Location = new System.Drawing.Point(130, 44);
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.Size = new System.Drawing.Size(59, 13);
            this.ngaytao.TabIndex = 34;
            this.ngaytao.Text = "29/3/2017";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày đặt hàng:";
            // 
            // huybtn
            // 
            this.huybtn.Location = new System.Drawing.Point(410, 408);
            this.huybtn.Name = "huybtn";
            this.huybtn.Size = new System.Drawing.Size(75, 23);
            this.huybtn.TabIndex = 7;
            this.huybtn.Text = "Hủy";
            this.huybtn.UseVisualStyleBackColor = true;
            this.huybtn.Click += new System.EventHandler(this.huybtn_Click);
            // 
            // luubtn
            // 
            this.luubtn.Location = new System.Drawing.Point(266, 408);
            this.luubtn.Name = "luubtn";
            this.luubtn.Size = new System.Drawing.Size(75, 23);
            this.luubtn.TabIndex = 6;
            this.luubtn.Text = "Lưu";
            this.luubtn.UseVisualStyleBackColor = true;
            this.luubtn.Click += new System.EventHandler(this.luubtn_Click);
            // 
            // madontxt
            // 
            this.madontxt.AutoSize = true;
            this.madontxt.Location = new System.Drawing.Point(130, 21);
            this.madontxt.Name = "madontxt";
            this.madontxt.Size = new System.Drawing.Size(41, 13);
            this.madontxt.TabIndex = 17;
            this.madontxt.Text = "DH001";
            // 
            // nhacungcaptxt
            // 
            this.nhacungcaptxt.Location = new System.Drawing.Point(133, 65);
            this.nhacungcaptxt.Name = "nhacungcaptxt";
            this.nhacungcaptxt.Size = new System.Drawing.Size(204, 20);
            this.nhacungcaptxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã đơn đặt hàng:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Tensp
            // 
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.Name = "Tensp";
            this.Tensp.Width = 170;
            // 
            // NCC
            // 
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.Name = "NCC";
            this.NCC.Width = 170;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng đặt";
            this.SL.Name = "SL";
            this.SL.Width = 170;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 170;
            // 
            // TaoDonDatHangF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 444);
            this.Controls.Add(this.panel1);
            this.Name = "TaoDonDatHangF";
            this.Text = "TaoDonDatHangF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dondathangtable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ngaytao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown soluongtxt;
        private System.Windows.Forms.TextBox tensptxt;
        private System.Windows.Forms.TextBox nhacungcaptxt;
        private System.Windows.Forms.Button huybtn;
        private System.Windows.Forms.Button luubtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label madontxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dondathangtable;
        private System.Windows.Forms.Button thembtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}