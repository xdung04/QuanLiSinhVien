﻿using System;
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
    public partial class UserCotrolCourse : UserControl
    {
        FormMain formMain;
        FormCourse courseForm;
        public UserCotrolCourse(FormCourse course, FormMain mainform)
        {
            InitializeComponent();
            this.courseForm = course;
            this.formMain = mainform;
        }

        private void linkLabelAccessCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string id = lblIdCourse.Text;
            AccessCourseForm accessCourseForm = new AccessCourseForm(id);
            formMain.OpenFormForOther(accessCourseForm, courseForm);
        }
    }
}
