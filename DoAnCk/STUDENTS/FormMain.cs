using DoAnCk.STUDENTS.Announs;
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
        public FormMain()
        {
            InitializeComponent();
        }



        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            Color color = btnKhoaHoc.BackColor;
            OpenForm(new FormCourse(), this,color);
        }

        private void OpenForm(Form form, Form formTag, Color backColor)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.BackColor = backColor;
            panelControl.Controls.Add(form);
            form.Show();
            form.Tag = formTag;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Color color = btnThongBao.BackColor;
            OpenForm(new FormNotify(), this, color);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
