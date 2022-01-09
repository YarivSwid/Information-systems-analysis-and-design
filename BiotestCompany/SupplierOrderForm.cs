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
    public partial class SupplierOrderForm : Form
    {
        public SupplierOrderForm()
        {
            InitializeComponent();
        }

        private void SupplierOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.getCustomerOrderDetail' table. You can move, or remove it, as needed.
            this.getCustomerOrderDetailTableAdapter.Fill(this.sAD_1DataSet.getCustomerOrderDetail);

        }
    }
}
