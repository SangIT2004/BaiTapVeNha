using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNam.Checked)
                MessageBox.Show("Giới tính bạn là: " + rbNam.Text, "Thông báo");
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNu.Checked)
                MessageBox.Show("Giới tính bạn là: " + rbNu.Text, "Thông báo");
        }
    }
}
