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
    public partial class UserControlEnrollCourse : UserControl
    {
        FormMain formMain;
        FormCourse courseForm;
        public UserControlEnrollCourse(FormCourse course, FormMain mainform)
        {
            InitializeComponent();
            this.courseForm = course;
            this.formMain = mainform;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                radioButton1.Text = "Thành Công!";
                radioButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("RoyalBlue");
            }
        }
    }
}
