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
    public partial class CRUDproductForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
        private DataTable dt;
        private int chosenID;
        private int chosenProudctID;

        public CRUDproductForm()
        {
            InitializeComponent();

            string role = Program.getLoggedIn().getRole().ToString();
            if (role.Equals("Secretary"))
            {
                button5.Hide();
                button4.Hide();
                button3.Hide();
            }
            if (role.Equals("Salesman"))
            {
                button2.Hide();
            }
            createDataGrid();

            dataGridView.ReadOnly = true;

        }

        private void createDataGrid()
        {
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select p.serialNumber, pt.name, p.status, p.expiration_date, s.companyName [supplied by], c.orgName from PRODUCTS p join PRODUCTTYPES pt on p.productType=pt.categorialNumber join SUPPLIERORDERS so on p.supplierOrderID=so.supplierOrderID join SUPPLIERS s on so.supplierID = s.supplierID join CUSTOMERORDERS co on p.customerOrderID=co.customerOrderID join CUSTOMERBIDS cb on co.basedOnCustBid=cb.bidID join CUSTOMERS c on cb.customer=c.custID", connection);

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].HeaderText = "SN";
            dataGridView.Columns[1].HeaderText = "Product";
            dataGridView.Columns[2].HeaderText = "Status";
            dataGridView.Columns[3].HeaderText = "Exp. date";
            dataGridView.Columns[4].HeaderText = "Supplier";
            dataGridView.Columns[5].HeaderText = "Customer";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchVal = textBox1.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select p.serialNumber, pt.name, p.status, p.expiration_date, s.companyName [supplied by], c.orgName from PRODUCTS p join PRODUCTTYPES pt on p.productType=pt.categorialNumber join SUPPLIERORDERS so on p.supplierOrderID=so.supplierOrderID join SUPPLIERS s on so.supplierID = s.supplierID join CUSTOMERORDERS co on p.customerOrderID=co.customerOrderID join CUSTOMERBIDS cb on co.basedOnCustBid=cb.bidID join CUSTOMERS c on cb.customer=c.custID" +
                " where p.serialNumber like'%" + searchVal + "%' or pt.name like'%" + searchVal + "%' or p.status like'%" + searchVal+ "%' or p.expiration_date like'%" + searchVal + "%' or s.companyName like'%" + searchVal + "%' or  c.orgName like '%"+searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad search value", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private Boolean checkCell(int i, string searchVal, DataGridViewRow row)
        {
            //MessageBox.Show("na");

            Boolean flag = row.Cells[i].Value.ToString().Equals(searchVal);
            //MessageBox.Show("asdsa"+flag,"asdsad");
            return flag;
        }
        private void search(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;

            
        }

        private void CRUDproductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.getCustomerOrderDetails' table. You can move, or remove it, as needed.
           // this.getCustomerOrderDetailsTableAdapter.Fill(this.sAD_1DataSet.getCustomerOrderDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void createStats2()
        {
            //int total = Program.Products.Count();
            //Dictionary<ProductStatus, int> stats = new Dictionary<ProductStatus, int>(); // initiate dictionary
            //stats.Add(Enum)
            //List<ProductStatus> allStatuses = Enum.GetValues(typeof(ProductStatus)).Cast<ProductStatus>().ToList(); // find all enum keys
            //foreach(ProductStatus s in allStatuses)
            //{
            //    stats.Add(s, 0); // add every ProductStatus to dictionary with value 0
            //}

            //foreach(Product p in Program.Products)
            //{
            //    foreach(ProductStatus s in stats.Keys)
            //    {
            //        if (p.GetProductStatus().Equals(s))
            //            stats[s] += 1; // add 1 to the status
            //    }
            //}
            //label2.Text = "Pending: "+stats[Pending]

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            new CustomerBidForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SupplierOrdersForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ProductPricingForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new IssueCertificateForm().Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
