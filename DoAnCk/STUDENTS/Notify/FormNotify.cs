using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCk.STUDENTS.Announs
{
    public partial class FormNotify : Form
    {
        public FormNotify()
        {
            InitializeComponent();

            // Thiết lập ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Ngày", 100);
            listView1.Columns.Add("Mô tả", 1000);

            AddNotification("12/04/2024", "Thông báo quan trọng về cập nhật hệ thống.");
            AddNotification("13/04/2024", "Thông báo khẩn cấp về bảo trì hệ thống.");
        }

        public void AddNotification(string date, string description)
        {
            ListViewItem item = new ListViewItem(date);
            item.SubItems.Add(description);
            listView1.Items.Add(item);
        }
    }
}
