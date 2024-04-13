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
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
        }
        LoginForm loginForm = new LoginForm();
        Form currentForm=null;
        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void OpenForm(Form f)
        {
       
            f.TopLevel = false;
            panelControl.Controls.Add(f);
            f.Show();
            f.Tag = this;
        }
        
        public void MainLoginForm_Load(object sender, EventArgs e)
        {
            OpenForm(loginForm);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
