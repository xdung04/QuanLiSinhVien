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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnCourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnNotify = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(this.lblHeader);
            panel1.Location = new System.Drawing.Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1247, 80);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(548, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(140, 31);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "TRANG CHỦ";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnEnroll);
            this.panel2.Controls.Add(this.btnCourse);
            this.panel2.Controls.Add(this.btnNotify);
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 764);
            this.panel2.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gray;
            this.btnExit.Image = global::DoAnCk.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(0, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Animated = true;
            this.btnEnroll.AnimatedGIF = true;
            this.btnEnroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnroll.FillColor = System.Drawing.Color.Gainsboro;
            this.btnEnroll.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.Gray;
            this.btnEnroll.Image = global::DoAnCk.Properties.Resources.add_to_cart;
            this.btnEnroll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnroll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEnroll.Location = new System.Drawing.Point(0, 380);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(200, 60);
            this.btnEnroll.TabIndex = 6;
            this.btnEnroll.Text = "Đăng Ký";
            this.btnEnroll.TextOffset = new System.Drawing.Point(15, 0);
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Animated = true;
            this.btnCourse.AnimatedGIF = true;
            this.btnCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCourse.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCourse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.Gray;
            this.btnCourse.Image = global::DoAnCk.Properties.Resources.online_learning__1_;
            this.btnCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCourse.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCourse.Location = new System.Drawing.Point(0, 320);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(200, 60);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Khóa Học";
            this.btnCourse.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Animated = true;
            this.btnNotify.AnimatedGIF = true;
            this.btnNotify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotify.FillColor = System.Drawing.Color.Gainsboro;
            this.btnNotify.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotify.ForeColor = System.Drawing.Color.Gray;
            this.btnNotify.Image = global::DoAnCk.Properties.Resources.universal;
            this.btnNotify.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNotify.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNotify.Location = new System.Drawing.Point(0, 260);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(200, 60);
            this.btnNotify.TabIndex = 4;
            this.btnNotify.Text = "Thông Báo";
            this.btnNotify.TextOffset = new System.Drawing.Point(20, 0);
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Animated = true;
            this.btnAccount.AnimatedGIF = true;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Gray;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccount.Location = new System.Drawing.Point(0, 200);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 60);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.TextOffset = new System.Drawing.Point(20, 0);
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BackgroundImage = global::DoAnCk.Properties.Resources.pink_panther1;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 200);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelControl.BackgroundImage = global::DoAnCk.Properties.Resources.hello;
            this.panelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControl.Location = new System.Drawing.Point(205, 80);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1242, 684);
            this.panelControl.TabIndex = 1;
            this.panelControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelControl_ControlRemoved);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1445, 764);
            this.ControlBox = false;
            this.Controls.Add(panel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnNotify;
        private Guna.UI2.WinForms.Guna2Button btnCourse;
        private Guna.UI2.WinForms.Guna2Button btnEnroll;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeader;
        public System.Windows.Forms.Panel panelControl;
    }
}

