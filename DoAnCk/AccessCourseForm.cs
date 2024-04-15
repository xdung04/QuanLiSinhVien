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
    public partial class AccessCourseForm : Form
    {
        string idCourse;
        public AccessCourseForm(string idCourse)
        {
            InitializeComponent();
            this.idCourse = idCourse;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void loadAssignment()
        {
            for (int i = 0; i < 3; i++)
            {
                UserControlAssignment userControl = new UserControlAssignment();

                // Đặt margin cho UserControl
                userControl.Margin = new Padding(15, 15, 15, 15); // Thay đổi 10 thành giá trị mong muốn

                flowLayoutPanel1.Controls.Add(userControl);
            }
        }


        private void AccessCourseForm_Load(object sender, EventArgs e)
        {
            loadAssignment();
        }
    }
}
