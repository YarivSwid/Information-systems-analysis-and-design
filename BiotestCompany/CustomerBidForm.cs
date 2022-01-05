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
    public partial class CustomerBidForm : Form
    {
        private Dictionary<ProductType, int> dict;
        private SqlConnection con;
        private DataTable dt;
        private DataTable dtt;
        private List<String> paymentTerms = new List<String>{ "CurrentPlus30", "CurrentPlus60", "Instant"};
        private Dictionary<ProductType, int> productTypesDict = new Dictionary<ProductType, int>();
        private List<ProductType> productTypesList = new List<ProductType>();

        private int chosenID;
        private int chosenProudctID;
        public CustomerBidForm()
        {

            InitializeComponent();
            comboBox3.DataSource = paymentTerms;
            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from customerBids", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            SQL_CON SC1 = new SQL_CON();
            SqlDataAdapter adapt1 = new SqlDataAdapter("select * from ProductTypes", connection);
            dtt = new DataTable();
            adapt1.Fill(dtt);
            dataGridView2.DataSource = dtt;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CustomerBidForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet3.PAYTERMS' table. You can move, or remove it, as needed.
            this.pAYTERMSTableAdapter.Fill(this.sAD_1DataSet3.PAYTERMS);
            // TODO: This line of code loads data into the 'sAD_1DataSet2.CUSTOMERBIDS' table. You can move, or remove it, as needed.
            this.cUSTOMERBIDSTableAdapter.Fill(this.sAD_1DataSet2.CUSTOMERBIDS);
            // TODO: This line of code loads data into the 'sAD_1DataSet1.PRODUCTTYPES' table. You can move, or remove it, as needed.
            this.pRODUCTTYPESTableAdapter.Fill(this.sAD_1DataSet2.PRODUCTTYPES);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchVal = textBox1.Text;
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from ProductType" +
    "                                       where categorialNumber like'%" + searchVal + "%' or name like'%" + searchVal + "%' or price like'%" + searchVal + "%'" +
    "or weightKG like'%" + searchVal + "%' or tempCels like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please fill all fields, in order to apply changes");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1 && rowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                chosenID = int.Parse(row.Cells[0].Value.ToString());
                textBox4.Text = row.Cells[5].Value.ToString(); //int?\
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[1].Value.ToString(); // double?
                comboBox3.Text = row.Cells[2].Value.ToString(); //box
                int temp = int.Parse(row.Cells[0].Value.ToString());
                Program.tempProductTypesDict = Program.findCustomerBid(temp).getBidDict();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentTerm PT = (PaymentTerm)Enum.Parse(typeof(PaymentTerm), "Instant");
            try
            { 
                 PT = (PaymentTerm)Enum.Parse(typeof(PaymentTerm),comboBox3.Text.ToString());
           
            
            User U = Program.findMyUser(chosenID);
            Customer Cos = Program.findMyCustomer(int.Parse(textBox4.Text));
            Contact Con = Program.findMyContact(textBox6.Text);
            double discount = double.Parse(textBox7.Text);


            CustomerBid CB = new CustomerBid(Program.generateBidID(), discount, PT, U, Con, Cos,Program.tempProductTypesDict, true);
            }
            catch
            { MessageBox.Show("Please select payment term from the list"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";//_txt?
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchVal = textBox2.Text;
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from ProductTypes" +
                "                                       where categorialNumber like'%" + searchVal + "%' or name like'%" + searchVal + "%' or price like'%" + searchVal + "%'" +
                "or weightKG like'%" + searchVal + "%' or tempCels like'%" + searchVal + "%'", connection);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int amount = 0;
            try
            {
                 amount = int.Parse(textBox3.Text);
            }
            catch (Exception ex) {}

            try
            {
                if (amount > 0)
                {
                    ProductType PT = Program.findProductType(int.Parse(textBox5.Text));
                    Program.tempProductTypesDict.Add(PT, amount);

                    textBox5.Clear();
                    textBox3.Clear();

                    MessageBox.Show("Product was added");
                }
                else {
                    MessageBox.Show("Could not add this product, you must choose amount (atleast 1 product)");
                }
            }
            catch (Exception ex) { 
                    MessageBox.Show("Could not add this product, check your product id"); 
            }

            
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >-1 && rowIndex < dataGridView2.Rows.Count - 1)
            {
                
                    DataGridViewRow row = dataGridView2.Rows[rowIndex];
                    chosenProudctID = int.Parse(row.Cells[0].Value.ToString());
                    textBox5.Text = row.Cells[0].Value.ToString();
               
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            string searchVal = textBox1.Text;
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from ProductType" +
                "                                       where categorialNumber like'%" + searchVal + "%' or name like'%" + searchVal + "%' or price like'%" + searchVal + "%'" +
                "or weightKG like'%" + searchVal + "%' or tempCels like'%" + searchVal + "%'", connection);
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

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ProductCheckList().Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
