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
    public partial class MenuManagerForm : Form
    {
        public MenuManagerForm()
        {
            InitializeComponent();
        }

        private void MenuManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chat_Butt_Click(object sender, EventArgs e)
        {
            new ChatMainForm(Program.getLoggedIn()).Show();
        }

        private void toProfile_Button_Click(object sender, EventArgs e)
        {

        }

        private void logout_Butt_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDusersForm().Show();
        }

        private void CustomersImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDcustomersForm().Show();
        }

        private void SuppliersImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDsuppliersForm().Show();
        }

        private void ProductsImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDproductForm().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
