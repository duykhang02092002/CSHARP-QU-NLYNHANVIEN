using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_QUẢNLYNHANVIEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            lbsDANHSACH.Items.Add(txtso.Text);

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            lbsDANHSACH.Items.RemoveAt(lbsDANHSACH.SelectedIndex);
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            if (lbsDANHSACH.SelectedIndex < 0) return;
            lbsDANHSACH.Items[lbsDANHSACH.SelectedIndex] = txtso.Text;
        }
    }
}
