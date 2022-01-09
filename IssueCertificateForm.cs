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
    public partial class IssueCertificateForm : Form
    {
        private SqlConnection con; // !!!!!!
        private DataTable dt;
        private Dictionary<ProductType, int> bidDetails;
        private Dictionary<string, int> productList;
        private Boolean is_order_chosen;
        private int cur_row;
        public IssueCertificateForm()
        {
            InitializeComponent();
            createGrid();
            productList = new Dictionary<string, int>();
            is_order_chosen = false;
            show_hide_labels(false);
            dataGridView1.ReadOnly = true;
            cUSTOMERORDERSDataGridView.ReadOnly = true;
        }

        public void createGrid() // !!!!!!
        {
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from customerorders", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            cUSTOMERORDERSDataGridView.DataSource = dt;
        }

        private void cUSTOMERORDERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERORDERSBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sAD_1DataSet2);

        }

        private void IssueCertificateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.CUSTOMERORDERS' table. You can move, or remove it, as needed.
            //this.cUSTOMERORDERSTableAdapter.Fill(this.sAD_1DataSet2.CUSTOMERORDERS);

        }
        private void show_hide_labels(Boolean flag)
        {
            label3.Visible = flag;
            label4.Visible = flag;
            label5.Visible = flag;
            label6.Visible = flag;
            label7.Visible = flag;
            label8.Visible = flag;
        }
        private void cUSTOMERORDERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridView1.Visible = false;
                productList = new Dictionary<string, int>();
                int rowIndex = e.RowIndex;
                cur_row = rowIndex;
                is_order_chosen = true;
                DataGridViewRow row = cUSTOMERORDERSDataGridView.Rows[rowIndex];

                if (row.Cells[0].Value.ToString() != "")
                {
                    string orderID = row.Cells[0].Value.ToString();
                    label3.Text = orderID;

                    double discount = assignLabels(orderID);
                    findOrderDetails(int.Parse(orderID));
                    calculateTotalPrice(discount);
                }
            }
        }

        public double assignLabels(string orderID)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetOrderDetails @orderID";
            c.Parameters.AddWithValue("@orderID", orderID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            double discount=0;

            while(rdr.Read())
            {
                label4.Text = rdr.GetValue(0).ToString();
                label5.Text = rdr.GetValue(1).ToString();
                textBox1.Text = rdr.GetValue(2).ToString();
                label6.Text = rdr.GetValue(3).ToString();
                label7.Text = rdr.GetValue(4).ToString();
                discount = double.Parse(rdr.GetValue(5).ToString());
            }
            show_hide_labels(true);
            return discount;
        }
        public void findOrderDetails(int orderID)
        {
            this.bidDetails = Program.findMyCustomerOrder(orderID).getCustomerBid().getBidDetails();
        }
        public void calculateTotalPrice(double discount)
        {
            double price = 0;
            int units = 0;
            foreach (ProductType p in bidDetails.Keys)
            {                
                if(!bidDetails.TryGetValue(p, out units))
                {
                    return;
                }
                this.productList.Add(p.getName(), units);
                price = price + (p.getPrice()*units);
            }
            price = price * (1 - discount/100);
            label8.Text = price.ToString();
        }

        private void SearchBar_txt_TextChanged(object sender, EventArgs e)
        {
            string searchVal = SearchBar_txt.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from customerorders" +
                "                                       where [customerOrderID] like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                cUSTOMERORDERSDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please fill all fields, in order to apply changes");
            }
        }

        private void clear_butt_Click(object sender, EventArgs e)
        {
            SearchBar_txt.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                if (is_order_chosen)
                {
                    dataGridView1.Visible = true;
                    BindingSource _bindingSource = new BindingSource();
                    dataGridView1.DataSource = _bindingSource;
                    _bindingSource.DataSource = productList;
                    this.dataGridView1.Columns[0].HeaderText = "Product";
                    this.dataGridView1.Columns[1].HeaderText = "Quantity";
                    button1.Text = "Hide product list";
                }
                else
                    MessageBox.Show("Please choose order first", "Oops!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Visible = false;
                button1.Text = "Show product list";
            }
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            checkEmail();
        }
        private void checkEmail()
        {
            if ((!textBox1.Text.Contains('@')) || ((textBox1.Text.Contains(" "))))
            {
                MessageBox.Show("Invalid email", "Oops!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.sendEmail(textBox1.Text, "Your Certificate from Biotest", "Dear " + label5.Text + ", the certificate for " + label4.Text +" company is attached.");
                MessageBox.Show("Shipping Certificate was sent to "+textBox1.Text, "Great success!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void sendEmail()
        {
            // send to contact
        }
        private void cUSTOMERORDERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Out_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
