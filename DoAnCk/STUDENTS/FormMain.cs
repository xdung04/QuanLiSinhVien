using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCk
{
    public partial class FormMain : Form
    {
        Form currentForm = null;
        Color currentColor = Color.White;
        public FormMain()
        {
            InitializeComponent();
            lblHeader.Text = "Trang Chủ";
        }
        public void OpenForm(Form form, Form formTag, Guna2Button btn, string color, string header)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;

            SetColor();
            currentColor = System.Drawing.ColorTranslator.FromHtml(color);      
            this.BackColor = currentColor;
            btn.FillColor = currentColor;
            lblHeader.Text = header;

            panelControl.Controls.Add(form);
            form.BackColor = currentColor;
            form.Show();
            form.Tag = formTag;
        }

        public void OpenFormForOther(Form form, Form formTag)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;

            panelControl.Controls.Add(form);
            form.Show();
            form.Tag = formTag;
        }

        private void SetColor()
        {
            btnNotify.FillColor = System.Drawing.ColorTranslator.FromHtml("Gainsboro");
            btnAccount.FillColor = System.Drawing.ColorTranslator.FromHtml("Gainsboro");
            btnCourse.FillColor = System.Drawing.ColorTranslator.FromHtml("Gainsboro");
            btnEnroll.FillColor = System.Drawing.ColorTranslator.FromHtml("Gainsboro");
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenForm(new AccountForm(), this, btnAccount, "#F9FBE7", "Thông Tin Cá Nhân");
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {

            OpenForm(new FormNotify(), this, btnNotify, "#DCEDC8", "Thông Báo");
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCourse(this), this, btnCourse, "#CFD8DC", "Khóa Học Của Tôi");
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCourse(this), this, btnEnroll, "#64B5F6", "Đăng Ký Học Phần");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            SetColor();
            lblHeader.Text = "Trang Chủ";
        }
    }
}
