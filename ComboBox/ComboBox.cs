using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedItem.ToString(),"Ngôn Ngữ");
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng anh", "Tiếng Pháp", "Tiếng Nhật" };
            this.comboBox1.DataSource = datas;
        }
    }
}
