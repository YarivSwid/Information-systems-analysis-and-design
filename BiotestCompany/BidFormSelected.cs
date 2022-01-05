using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiotestCompany
{
    public partial class BidFormSelected : Form
    {
        public BidFormSelected()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BidFormSelected_Load(object sender, EventArgs e)
        {

        }
    }
}
