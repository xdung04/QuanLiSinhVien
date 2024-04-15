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
        public FormCourse(FormMain formTag)
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                UserCotrolCourse userControl = new UserCotrolCourse(this,formTag);

                // Đặt margin cho UserControl
                userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                flowLayoutPanel1.Controls.Add(userControl);
            }
        }


        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
