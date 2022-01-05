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
    public partial class CRUDsuppliersForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private int chosenID;
        private string newNotes;
        public CRUDsuppliersForm()
        {
            InitializeComponent();

            label5.Hide();
            label7.Hide();
            label8.Hide();
            label6.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            EditNotes_Butt.Hide();

            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select supplierID, companyName, country, officialEmail, PunctualityRank, qualityRank, totalRank from suppliers", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            sUPPLIERSDataGridView.DataSource = dt;
        }

        public CRUDsuppliersForm(string newNo)
        {
            InitializeComponent();

            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select supplierID, companyName, country, officialEmail, PunctualityRank, qualityRank, totalRank from suppliers", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            sUPPLIERSDataGridView.DataSource = dt;
            this.newNotes = newNo;
        }


        private void sUPPLIERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sUPPLIERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_1DataSet);

        }

        private void CRUDsuppliersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.SUPPLIERS' table. You can move, or remove it, as needed.
            this.sUPPLIERSTableAdapter.Fill(this.sAD_1DataSet.SUPPLIERS);

        }
        private void SearchBar_txt_TextChanged(object sender, EventArgs e)
        {
            string searchVal = SearchBar_txt.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select supplierID, companyName, country, officialEmail, PunctualityRank, qualityRank, totalRank from suppliers" +
                "                                       where companyName like'%" + searchVal + "%' or country like'%" + searchVal + "%' or supplierID like'%" + searchVal + "%'" ,connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                sUPPLIERSDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBar_txt.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void refresh14()
        {
            label14.Text = Program.findMySupplier(this.chosenID).getNotes();
        }

        private void sUPPLIERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void sUPPLIERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1 && rowIndex < sUPPLIERSDataGridView.Rows.Count - 1)
            {
                DataGridViewRow row = sUPPLIERSDataGridView.Rows[rowIndex];
                chosenID = int.Parse(row.Cells[0].Value.ToString());
                CompanyName_txt.Text = row.Cells[1].Value.ToString();
                Country_txt.Text = row.Cells[2].Value.ToString();
                Email_txt.Text = row.Cells[3].Value.ToString();

                label5.Show();
                label7.Show();
                label8.Show();
                label6.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                EditNotes_Butt.Show();

                label11.Text = row.Cells[4].Value.ToString();
                label12.Text = row.Cells[5].Value.ToString();
                label13.Text = row.Cells[6].Value.ToString();
                label14.Text = Program.findMySupplier(this.chosenID).getNotes();
            }
        }

        private void add_Butt_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier S = new Supplier(Program.assignSuppID(), CompanyName_txt.Text, Country_txt.Text, Email_txt.Text, 0, 0, 0, "no notes yet, you can add some", new List<Contact>(), new List<ProductType>(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SearchBar_txt_TextChanged(sender, e);
        }

        private void Update_Butt_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier S = Program.findMySupplier(chosenID);
                S.setCompanyName(CompanyName_txt.Text);
                S.setCountry(Country_txt.Text);
                S.setMail(Email_txt.Text);
                S.updateSupplierAlon();
                SearchBar_txt_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes. " +
                    "the district must be one of the listed ones", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditNotes_Butt_Click(object sender, EventArgs e)
        {
            new SupplierNotesForm(label14.Text, Program.findMySupplier(this.chosenID), this).Show();
        }
        public void refreshNote(string str)
        {
            label14.Text = str;
        }

        private void Out_Butt_Click(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception Ex)
            {
                MessageBox.Show("The system can not identify you! Please restart it and log in.", "Security Alert!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private void sUPPLIERSDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Country_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
