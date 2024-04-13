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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            MainLoginForm mainLoginForm = new MainLoginForm();
            SignUpForm signUpForm = new SignUpForm();
            mainLoginForm.OpenForm(signUpForm);
            mainLoginForm.Show();
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLoginForm = new MainLoginForm();
            FogetAccountForm fAccountForm = new FogetAccountForm();
            mainLoginForm.OpenForm(fAccountForm); 
            mainLoginForm.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           
                txtPassword.PasswordChar = '\0';
                btnSeenPass.Visible = false;
           
        }

        private void btnUnSeenPass_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnSeenPass.Visible = true;
        }
    }
}
