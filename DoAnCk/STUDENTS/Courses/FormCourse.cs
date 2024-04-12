using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCk
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                flowLayoutPanel1.Controls.Add(new UserCotrolCourse());

            }
        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
