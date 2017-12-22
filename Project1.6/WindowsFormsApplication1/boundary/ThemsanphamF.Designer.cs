namespace WindowsFormsApplication1.boundary
{
    partial class ThemsanphamF
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
            this.masptxt = new System.Windows.Forms.TextBox();
            this.giabannud = new System.Windows.Forms.NumericUpDown();
            this.soluongnud = new System.Windows.Forms.NumericUpDown();
            this.sizecb = new System.Windows.Forms.ComboBox();
            this.tensptxt = new System.Windows.Forms.TextBox();
            this.nhacctxt = new System.Windows.Forms.TextBox();
            this.huybtn = new System.Windows.Forms.Button();
            this.luuspbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ngaynhapsplb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.baothemthanhcongbtn = new System.Windows.Forms.Button();
            this.baothemthatbaibtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giabannud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.masptxt);
            this.panel1.Controls.Add(this.giabannud);
            this.panel1.Controls.Add(this.soluongnud);
            this.panel1.Controls.Add(this.sizecb);
            this.panel1.Controls.Add(this.tensptxt);
            this.panel1.Controls.Add(this.nhacctxt);
            this.panel1.Controls.Add(this.huybtn);
            this.panel1.Controls.Add(this.luuspbtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ngaynhapsplb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 304);
            this.panel1.TabIndex = 1;
            // 
            // masptxt
            // 
            this.masptxt.BackColor = System.Drawing.SystemColors.Window;
            this.masptxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.masptxt.Location = new System.Drawing.Point(37, 72);
            this.masptxt.Name = "masptxt";
            this.masptxt.Size = new System.Drawing.Size(150, 20);
            this.masptxt.TabIndex = 1;
            // 
            // giabannud
            // 
            this.giabannud.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.giabannud.Location = new System.Drawing.Point(272, 197);
            this.giabannud.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.giabannud.Name = "giabannud";
            this.giabannud.Size = new System.Drawing.Size(150, 20);
            this.giabannud.TabIndex = 6;
            this.giabannud.ThousandsSeparator = true;
            this.giabannud.Enter += new System.EventHandler(this.giabannud_Enter);
            // 
            // soluongnud
            // 
            this.soluongnud.Location = new System.Drawing.Point(37, 197);
            this.soluongnud.Name = "soluongnud";
            this.soluongnud.Size = new System.Drawing.Size(150, 20);
            this.soluongnud.TabIndex = 5;
            this.soluongnud.Enter += new System.EventHandler(this.soluongnud_Enter);
            // 
            // sizecb
            // 
            this.sizecb.FormattingEnabled = true;
            this.sizecb.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.sizecb.Location = new System.Drawing.Point(37, 132);
            this.sizecb.Name = "sizecb";
            this.sizecb.Size = new System.Drawing.Size(150, 21);
            this.sizecb.TabIndex = 3;
            // 
            // tensptxt
            // 
            this.tensptxt.Location = new System.Drawing.Point(272, 72);
            this.tensptxt.Name = "tensptxt";
            this.tensptxt.Size = new System.Drawing.Size(150, 20);
            this.tensptxt.TabIndex = 2;
            // 
            // nhacctxt
            // 
            this.nhacctxt.Location = new System.Drawing.Point(272, 132);
            this.nhacctxt.Name = "nhacctxt";
            this.nhacctxt.Size = new System.Drawing.Size(150, 20);
            this.nhacctxt.TabIndex = 4;
            // 
            // huybtn
            // 
            this.huybtn.Location = new System.Drawing.Point(272, 239);
            this.huybtn.Name = "huybtn";
            this.huybtn.Size = new System.Drawing.Size(75, 23);
            this.huybtn.TabIndex = 8;
            this.huybtn.Text = "Hủy";
            this.huybtn.UseVisualStyleBackColor = true;
            this.huybtn.Click += new System.EventHandler(this.huybtn_Click);
            // 
            // luuspbtn
            // 
            this.luuspbtn.Location = new System.Drawing.Point(112, 239);
            this.luuspbtn.Name = "luuspbtn";
            this.luuspbtn.Size = new System.Drawing.Size(75, 23);
            this.luuspbtn.TabIndex = 7;
            this.luuspbtn.Text = "Lưu";
            this.luuspbtn.UseVisualStyleBackColor = true;
            this.luuspbtn.Click += new System.EventHandler(this.luuspbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hãng*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Size*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên sản phẩm*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã sản phẩm*";
            // 
            // ngaynhapsplb
            // 
            this.ngaynhapsplb.AutoSize = true;
            this.ngaynhapsplb.Location = new System.Drawing.Point(99, 21);
            this.ngaynhapsplb.Name = "ngaynhapsplb";
            this.ngaynhapsplb.Size = new System.Drawing.Size(59, 13);
            this.ngaynhapsplb.TabIndex = 17;
            this.ngaynhapsplb.Text = "29/3/2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày nhập:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.baothemthanhcongbtn);
            this.splitContainer1.Panel1.Controls.Add(this.baothemthatbaibtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(468, 376);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 24;
            // 
            // baothemthanhcongbtn
            // 
            this.baothemthanhcongbtn.BackColor = System.Drawing.Color.LightGreen;
            this.baothemthanhcongbtn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sign_check_icon;
            this.baothemthanhcongbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.baothemthanhcongbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baothemthanhcongbtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.baothemthanhcongbtn.FlatAppearance.BorderSize = 2;
            this.baothemthanhcongbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baothemthanhcongbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.baothemthanhcongbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baothemthanhcongbtn.Location = new System.Drawing.Point(0, 0);
            this.baothemthanhcongbtn.Name = "baothemthanhcongbtn";
            this.baothemthanhcongbtn.Size = new System.Drawing.Size(468, 68);
            this.baothemthanhcongbtn.TabIndex = 1;
            this.baothemthanhcongbtn.Text = "Thêm thành công";
            this.baothemthanhcongbtn.UseVisualStyleBackColor = false;
            this.baothemthanhcongbtn.Click += new System.EventHandler(this.anthongbao_Click);
            // 
            // baothemthatbaibtn
            // 
            this.baothemthatbaibtn.BackColor = System.Drawing.Color.Pink;
            this.baothemthatbaibtn.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.warning_6_xl;
            this.baothemthatbaibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.baothemthatbaibtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baothemthatbaibtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.baothemthatbaibtn.FlatAppearance.BorderSize = 2;
            this.baothemthatbaibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baothemthatbaibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.baothemthatbaibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baothemthatbaibtn.Location = new System.Drawing.Point(0, 0);
            this.baothemthatbaibtn.Name = "baothemthatbaibtn";
            this.baothemthatbaibtn.Size = new System.Drawing.Size(468, 68);
            this.baothemthatbaibtn.TabIndex = 0;
            this.baothemthatbaibtn.Text = "Xảy ra lỗi khi thêm";
            this.baothemthatbaibtn.UseVisualStyleBackColor = false;
            this.baothemthatbaibtn.Click += new System.EventHandler(this.anthongbao_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThemsanphamF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 376);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ThemsanphamF";
            this.Text = "ThemsanphamF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giabannud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongnud)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown giabannud;
        private System.Windows.Forms.NumericUpDown soluongnud;
        private System.Windows.Forms.ComboBox sizecb;
        private System.Windows.Forms.TextBox tensptxt;
        private System.Windows.Forms.TextBox nhacctxt;
        private System.Windows.Forms.TextBox masptxt;
        private System.Windows.Forms.Button huybtn;
        private System.Windows.Forms.Button luuspbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ngaynhapsplb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button baothemthatbaibtn;
        private System.Windows.Forms.Button baothemthanhcongbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}