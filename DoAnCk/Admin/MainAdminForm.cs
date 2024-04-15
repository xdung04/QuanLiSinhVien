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
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void OpenForm(Form f)
        {

            f.TopLevel = false;
            panelHome.Controls.Add(f);
            f.Show();
            f.Tag = this;
        }
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            OpenForm(teacherForm);
        }
    }
}
