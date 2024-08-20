using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsselect = listSelectionMode.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--)
            {
                ListChon.Items.Add(listSelectionMode.SelectedItems[i]);
                listSelectionMode.Items.Remove(listSelectionMode.SelectedItems[i]);
                // lstDanhsach.Items.RemoveAt(lstDanhsach.SelectedIndices[i]);
            }
        }

        private void listSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = ListChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                ListChon.Items.RemoveAt(ListChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
