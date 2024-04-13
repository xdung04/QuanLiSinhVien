namespace DoAnCk
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThongBao = new System.Windows.Forms.ToolStripButton();
            this.btnKhoaHoc = new System.Windows.Forms.ToolStripButton();
            this.btnDangKy = new System.Windows.Forms.ToolStripButton();
            this.btnTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelControl.Location = new System.Drawing.Point(200, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1247, 763);
            this.panelControl.TabIndex = 1;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 554);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThongBao,
            this.btnKhoaHoc,
            this.btnDangKy,
            this.btnTaiKhoan,
            this.btnThoat,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(201, 554);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThongBao
            // 
            this.btnThongBao.AutoSize = false;
            this.btnThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThongBao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThongBao.Image = ((System.Drawing.Image)(resources.GetObject("btnThongBao.Image")));
            this.btnThongBao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThongBao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(150, 50);
            this.btnThongBao.Text = "Thông Báo";
            this.btnThongBao.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnKhoaHoc
            // 
            this.btnKhoaHoc.AutoSize = false;
            this.btnKhoaHoc.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnKhoaHoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnKhoaHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoaHoc.Image")));
            this.btnKhoaHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKhoaHoc.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhoaHoc.Name = "btnKhoaHoc";
            this.btnKhoaHoc.Size = new System.Drawing.Size(150, 50);
            this.btnKhoaHoc.Text = "Khóa Học";
            this.btnKhoaHoc.Click += new System.EventHandler(this.btnKhoaHoc_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoSize = false;
            this.btnDangKy.BackColor = System.Drawing.Color.Cyan;
            this.btnDangKy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.Image")));
            this.btnDangKy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(150, 50);
            this.btnDangKy.Text = "Đăng Ký ";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.AutoSize = false;
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Plum;
            this.btnTaiKhoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(150, 50);
            this.btnTaiKhoan.Text = "Tài Khoản";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 50);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(200, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 764);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnCk.Properties.Resources.logoHcmute;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1445, 764);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThongBao;
        private System.Windows.Forms.ToolStripButton btnKhoaHoc;
        private System.Windows.Forms.ToolStripButton btnDangKy;
        private System.Windows.Forms.ToolStripButton btnTaiKhoan;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

