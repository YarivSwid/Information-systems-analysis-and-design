using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiotestCompany
{
    public partial class CRUDcustomersForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private int chosenID;
        public CRUDcustomersForm()
        {
            InitializeComponent();

            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from customers", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            cUSTOMERSDataGridView.DataSource = dt;
        }

        private void cUSTOMERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_1DataSet);

        }

        private void CRUDcustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.sAD_1DataSet.CUSTOMERS);
            District_Box.DataSource = Enum.GetValues(typeof(District));

        }

        private void SearchBar_txt_TextChanged(object sender, EventArgs e)
        {
            string searchVal = SearchBar_txt.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from customers" +
                "                                       where orgname like'%" + searchVal + "%' or custid like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                cUSTOMERSDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uSERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1 && rowIndex < cUSTOMERSDataGridView.Rows.Count - 1)
            {
                DataGridViewRow row = cUSTOMERSDataGridView.Rows[rowIndex];
                chosenID = int.Parse(row.Cells[0].Value.ToString());
                OrgName_txt.Text = row.Cells[1].Value.ToString();
                DeliveryAddress_txt.Text = row.Cells[3].Value.ToString();
                Building_txt.Text = row.Cells[4].Value.ToString();
                Room_txt.Text = row.Cells[5].Value.ToString();
                District_Box.Text = row.Cells[2].Value.ToString();
            }
        }
        private void Add_butt_Click(object sender, EventArgs e)
        {
            try
            {
                District D = (District)Enum.Parse(typeof(District), District_Box.Text.ToString());
                Customer C = new Customer(Program.assignCustID(), OrgName_txt.Text, D, DeliveryAddress_txt.Text, Building_txt.Text, int.Parse(Room_txt.Text), new List<Contact>(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SearchBar_txt_TextChanged(sender, e);
        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                District D = (District)Enum.Parse(typeof(District), District_Box.Text.ToString());
                Customer C = Program.findMyCustomer(chosenID);
                C.setOrgName(OrgName_txt.Text);
                C.setDeliveryAddress(DeliveryAddress_txt.Text);
                C.setBuildingNumber(Building_txt.Text);
                C.setRoomNumber(int.Parse(Room_txt.Text));
                C.setDistrict(D);
                C.updateCustomer();
                SearchBar_txt_TextChanged(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes. " +
                    "the district must be one of the listed ones", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Out_Butt_Click(object sender, EventArgs e)
        {
            try
            {
                string role = Program.getLoggedIn().getRole().ToString();
                if (Program.getLoggedIn().getRole().ToString() == "Manager")
                {
                    new MenuManagerForm().Show();
                }
                else if (Program.getLoggedIn().getRole().ToString() == "Salesman")
                {
                    new MenuSalesmanForm().Show();
                }
                else
                {

                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("The system can not identify you! Please restart it and log in.", "Security Alert!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }
        private void room_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || (Room_txt.Text.Length > 8))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBar_txt.Text = "";
        }

        private void cUSTOMERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Room_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
