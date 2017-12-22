namespace WindowsFormsApplication1.boundary
{
    partial class menu
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
            this.taohoadonbtn = new System.Windows.Forms.Button();
            this.quanlisanphambtn = new System.Windows.Forms.Button();
            this.thongkebtn = new System.Windows.Forms.Button();
            this.taodondathangbtn = new System.Windows.Forms.Button();
            this.kiemkedonhangbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taohoadonbtn
            // 
            this.taohoadonbtn.Location = new System.Drawing.Point(80, 14);
            this.taohoadonbtn.Name = "taohoadonbtn";
            this.taohoadonbtn.Size = new System.Drawing.Size(106, 23);
            this.taohoadonbtn.TabIndex = 0;
            this.taohoadonbtn.Text = "Tạo hóa đơn";
            this.taohoadonbtn.UseVisualStyleBackColor = true;
            this.taohoadonbtn.Click += new System.EventHandler(this.taohoadonbtn_Click);
            // 
            // quanlisanphambtn
            // 
            this.quanlisanphambtn.Location = new System.Drawing.Point(80, 170);
            this.quanlisanphambtn.Name = "quanlisanphambtn";
            this.quanlisanphambtn.Size = new System.Drawing.Size(106, 23);
            this.quanlisanphambtn.TabIndex = 1;
            this.quanlisanphambtn.Text = "Quản lí sản phẩm";
            this.quanlisanphambtn.UseVisualStyleBackColor = true;
            this.quanlisanphambtn.Click += new System.EventHandler(this.quanlisanphambtn_Click);
            // 
            // thongkebtn
            // 
            this.thongkebtn.Location = new System.Drawing.Point(80, 222);
            this.thongkebtn.Name = "thongkebtn";
            this.thongkebtn.Size = new System.Drawing.Size(106, 23);
            this.thongkebtn.TabIndex = 2;
            this.thongkebtn.Text = "Thống kê";
            this.thongkebtn.UseVisualStyleBackColor = true;
            this.thongkebtn.Click += new System.EventHandler(this.thongkebtn_Click);
            // 
            // taodondathangbtn
            // 
            this.taodondathangbtn.Location = new System.Drawing.Point(80, 66);
            this.taodondathangbtn.Name = "taodondathangbtn";
            this.taodondathangbtn.Size = new System.Drawing.Size(106, 23);
            this.taodondathangbtn.TabIndex = 3;
            this.taodondathangbtn.Text = "Tạo đơn đặt hàng";
            this.taodondathangbtn.UseVisualStyleBackColor = true;
            this.taodondathangbtn.Click += new System.EventHandler(this.taodondathangbtn_Click);
            // 
            // kiemkedonhangbtn
            // 
            this.kiemkedonhangbtn.Location = new System.Drawing.Point(80, 118);
            this.kiemkedonhangbtn.Name = "kiemkedonhangbtn";
            this.kiemkedonhangbtn.Size = new System.Drawing.Size(106, 23);
            this.kiemkedonhangbtn.TabIndex = 4;
            this.kiemkedonhangbtn.Text = "Kiểm kê đơn hàng";
            this.kiemkedonhangbtn.UseVisualStyleBackColor = true;
            this.kiemkedonhangbtn.Click += new System.EventHandler(this.kiemkedonhangbtn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.kiemkedonhangbtn);
            this.Controls.Add(this.taodondathangbtn);
            this.Controls.Add(this.thongkebtn);
            this.Controls.Add(this.quanlisanphambtn);
            this.Controls.Add(this.taohoadonbtn);
            this.Name = "menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taohoadonbtn;
        private System.Windows.Forms.Button quanlisanphambtn;
        private System.Windows.Forms.Button thongkebtn;
        private System.Windows.Forms.Button taodondathangbtn;
        private System.Windows.Forms.Button kiemkedonhangbtn;
    }
}

