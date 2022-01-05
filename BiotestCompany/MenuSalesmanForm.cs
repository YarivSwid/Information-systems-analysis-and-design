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
            new CRUDcustomersForm().Show();             ////this is CRUD customers
        }

        private void toSuppliersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDsuppliersForm().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           new ChatMainForm(Program.getLoggedIn()).Show();
        }

        private void logout_Butt_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void to_Click(object sender, EventArgs e)
        {
            new CRUDproductForm().Show();
        }
    }
}
