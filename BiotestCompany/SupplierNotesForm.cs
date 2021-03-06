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
    public partial class SupplierNotesForm : Form
    {
        private Supplier sup;
        private string lastNote;
        private CRUDsuppliersForm aba;
        public SupplierNotesForm(string last, Supplier S, CRUDsuppliersForm aba)
        {
            InitializeComponent();
            this.sup = S;
            this.lastNote = last;
            textBox1.Text = this.lastNote;
            this.aba = aba;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Apply_Butt_Click(object sender, EventArgs e)
        {
            this.sup.setNotes(textBox1.Text);
            sup.updateSupplier();
            this.aba.refreshNote(textBox1.Text);
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupplierNotesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
