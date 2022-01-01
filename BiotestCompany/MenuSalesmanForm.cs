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
    public partial class MenuSalesmanForm : Form
    {
        public MenuSalesmanForm()
        {
            InitializeComponent();
        }

        private void toClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new CRUDcustomersForm().Show();             ////this is CRUD customers
        }
    }
}
