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

            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from products", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchVal = textBox1.Text;
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from dbo.getCustomerOrderDetails" +
                "                                       where serialNumber like'%" + searchVal + "%' or unitsNumber like'%" + searchVal + "%' or status like'%" + searchVal + "%'" +
                "or name like'%" + searchVal + "%' or supplierOrderID like'%" + searchVal + "%'or customerOrderID like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please fill all fields, in order to apply changes");
            }
        }

        private void CRUDproductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.getCustomerOrderDetails' table. You can move, or remove it, as needed.
            this.getCustomerOrderDetailsTableAdapter.Fill(this.sAD_1DataSet.getCustomerOrderDetails);
            // TODO: This line of code loads data into the 'sAD_1DataSet3.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.sAD_1DataSet3.PRODUCTS);

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
