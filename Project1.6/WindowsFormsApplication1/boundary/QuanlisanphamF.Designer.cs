namespace WindowsFormsApplication1.boundary
{
    partial class QuanlisanphamF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.capnhatbtn = new System.Windows.Forms.Button();
            this.soluongmoinud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.masplbl = new System.Windows.Forms.Label();
            this.danhsachspdgv = new System.Windows.Forms.DataGridView();
            this.themsanphambtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.giabantutxt = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.giabandentxt = new System.Windows.Forms.NumericUpDown();
            this.locbtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timkiemnangcaobtn = new System.Windows.Forms.Button();
            this.timkiemtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.thoatbtn = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongmoinud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachspdgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giabantutxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giabandentxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.capnhatbtn);
            this.panel2.Controls.Add(this.soluongmoinud);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.masplbl);
            this.panel2.Controls.Add(this.danhsachspdgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 243);
            this.panel2.TabIndex = 3;
            // 
            // capnhatbtn
            // 
            this.capnhatbtn.Location = new System.Drawing.Point(410, 8);
            this.capnhatbtn.Name = "capnhatbtn";
            this.capnhatbtn.Size = new System.Drawing.Size(75, 23);
            this.capnhatbtn.TabIndex = 8;
            this.capnhatbtn.Text = "Cập nhật";
            this.capnhatbtn.UseVisualStyleBackColor = true;
            this.capnhatbtn.Click += new System.EventHandler(this.capnhatbtn_Click);
            // 
            // soluongmoinud
            // 
            this.soluongmoinud.Location = new System.Drawing.Point(258, 11);
            this.soluongmoinud.Name = "soluongmoinud";
            this.soluongmoinud.Size = new System.Drawing.Size(120, 20);
            this.soluongmoinud.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cập nhật số lượng:";
            // 
            // masplbl
            // 
            this.masplbl.AutoSize = true;
            this.masplbl.Location = new System.Drawing.Point(152, 13);
            this.masplbl.Name = "masplbl";
            this.masplbl.Size = new System.Drawing.Size(71, 13);
            this.masplbl.TabIndex = 5;
            this.masplbl.Text = "Mã sản phẩm";
            // 
            // danhsachspdgv
            // 
            this.danhsachspdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachspdgv.Location = new System.Drawing.Point(0, 50);
            this.danhsachspdgv.Name = "danhsachspdgv";
            this.danhsachspdgv.Size = new System.Drawing.Size(848, 193);
            this.danhsachspdgv.TabIndex = 0;
            this.danhsachspdgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachspdgv_CellDoubleClick);
            // 
            // themsanphambtn
            // 
            this.themsanphambtn.Location = new System.Drawing.Point(31, 12);
            this.themsanphambtn.Name = "themsanphambtn";
            this.themsanphambtn.Size = new System.Drawing.Size(152, 23);
            this.themsanphambtn.TabIndex = 1;
            this.themsanphambtn.Text = "Thêm sản phẩm mới";
            this.themsanphambtn.UseVisualStyleBackColor = true;
            this.themsanphambtn.Click += new System.EventHandler(this.themsanphambtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.giabantutxt);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.giabandentxt);
            this.panel1.Controls.Add(this.locbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 134);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "đến";
            // 
            // giabantutxt
            // 
            this.giabantutxt.Location = new System.Drawing.Point(478, 21);
            this.giabantutxt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.giabantutxt.Name = "giabantutxt";
            this.giabantutxt.Size = new System.Drawing.Size(158, 20);
            this.giabantutxt.TabIndex = 10;
            this.giabantutxt.ThousandsSeparator = true;
            this.giabantutxt.Enter += new System.EventHandler(this.giabantutxt_Enter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(378, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Giá bán từ";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox1.Location = new System.Drawing.Point(131, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(378, 58);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Ngày nhập";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Size";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Tình trạng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Còn tồn";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(131, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hết hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // giabandentxt
            // 
            this.giabandentxt.Location = new System.Drawing.Point(674, 21);
            this.giabandentxt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.giabandentxt.Name = "giabandentxt";
            this.giabandentxt.Size = new System.Drawing.Size(158, 20);
            this.giabandentxt.TabIndex = 11;
            this.giabandentxt.ThousandsSeparator = true;
            this.giabandentxt.Enter += new System.EventHandler(this.giabandentxt_Enter);
            // 
            // locbtn
            // 
            this.locbtn.Location = new System.Drawing.Point(749, 95);
            this.locbtn.Name = "locbtn";
            this.locbtn.Size = new System.Drawing.Size(75, 23);
            this.locbtn.TabIndex = 14;
            this.locbtn.Text = "Lọc";
            this.locbtn.UseVisualStyleBackColor = true;
            this.locbtn.Click += new System.EventHandler(this.locbtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(31, 107);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(848, 381);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 5;
            // 
            // timkiemnangcaobtn
            // 
            this.timkiemnangcaobtn.Location = new System.Drawing.Point(641, 69);
            this.timkiemnangcaobtn.Name = "timkiemnangcaobtn";
            this.timkiemnangcaobtn.Size = new System.Drawing.Size(136, 23);
            this.timkiemnangcaobtn.TabIndex = 3;
            this.timkiemnangcaobtn.Text = "Tìm kiếm nâng cao";
            this.timkiemnangcaobtn.UseVisualStyleBackColor = true;
            this.timkiemnangcaobtn.Click += new System.EventHandler(this.timkiemnangcaobtn_Click);
            // 
            // timkiemtxt
            // 
            this.timkiemtxt.Location = new System.Drawing.Point(31, 71);
            this.timkiemtxt.Name = "timkiemtxt";
            this.timkiemtxt.Size = new System.Drawing.Size(343, 20);
            this.timkiemtxt.TabIndex = 2;
            this.timkiemtxt.TextChanged += new System.EventHandler(this.timkiemtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tìm kiếm theo tên hoặc mã sản phẩm";
            // 
            // thoatbtn
            // 
            this.thoatbtn.Location = new System.Drawing.Point(804, 69);
            this.thoatbtn.Name = "thoatbtn";
            this.thoatbtn.Size = new System.Drawing.Size(75, 23);
            this.thoatbtn.TabIndex = 27;
            this.thoatbtn.Text = "Thoát";
            this.thoatbtn.UseVisualStyleBackColor = true;
            this.thoatbtn.Click += new System.EventHandler(this.thoatbtn_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(34, 94);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(52, 17);
            this.checkBox5.TabIndex = 27;
            this.checkBox5.Text = "Hãng";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 28;
            // 
            // QuanlisanphamF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 500);
            this.Controls.Add(this.thoatbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timkiemtxt);
            this.Controls.Add(this.timkiemnangcaobtn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.themsanphambtn);
            this.Name = "QuanlisanphamF";
            this.Text = "QuanlisanphamF";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongmoinud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachspdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giabantutxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giabandentxt)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView danhsachspdgv;
        private System.Windows.Forms.Button themsanphambtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown giabandentxt;
        private System.Windows.Forms.Button locbtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button timkiemnangcaobtn;
        private System.Windows.Forms.TextBox timkiemtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown giabantutxt;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button thoatbtn;
        private System.Windows.Forms.Button capnhatbtn;
        private System.Windows.Forms.NumericUpDown soluongmoinud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label masplbl;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}