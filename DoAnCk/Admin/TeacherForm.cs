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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
        public void LoadUser()
        {
            for(int i = 1; i < 10; i++)
            {
                ucAccount account = new ucAccount();
                account.lblSTT.Text = i.ToString(); 
                panalAccount.Controls.Add(account);
            }
        }
    }
}
