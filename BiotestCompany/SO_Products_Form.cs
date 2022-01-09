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
using System.IO;

namespace BiotestCompany
{
    public partial class SO_Products_Form : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private int chosenPID;
        private int chosenID;

        private int supplierID;
        private Dictionary<ProductType, int> productTypesDict = new Dictionary<ProductType, int>();
        private Dictionary<int, int> temp = new Dictionary<int, int>();
        private SupplierOrder supplierOrderChoosen;
        public SO_Products_Form(int sodID , int supplierID)
        {
            if (sodID != 0)
            {
                supplierOrderChoosen = Program.findMySupplierOrder(sodID);

                productTypesDict = supplierOrderChoosen.getProducts();

                int count = productTypesDict.Count();
                int i = 0;

                while (count > i)
                {
                    int a = productTypesDict.ElementAt(i).Key.getCatNumber();
                    int b = productTypesDict.ElementAt(i).Value;
                    temp.Add(a,b);
                    i = i + 1;
                }
                InitializeComponent();

                BindingSource _bindingSource = new BindingSource();
                dataGridView2.DataSource = _bindingSource;
                _bindingSource.DataSource = temp;
            }
            else {
                InitializeComponent();
            }

            this.supplierID = supplierID;
            label1.Text = "Offered Product Types By " + Program.findMySupplier(this.supplierID).getCompanyName() + " (Supplier No. " + this.supplierID + ")";
            currently_label.Text = "Currently in order:";

            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select SB.supplierID, PT.categorialNumber, PT.name, PT.shelfLifeDays, SB.pricePerUnit " +
                "                                       from SUPPLIERBIDS as SB JOIN PRODUCTTYPES AS PT ON SB.categorialNumber = PT.categorialNumber", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt; //supplierID is hidden, so column indexes are + 1

            if(temp.Count() ==0)
            {
                temp.Add(0, 0);
                BindingSource _bindingSource = new BindingSource();
                dataGridView2.DataSource = _bindingSource;
                _bindingSource.DataSource = temp;
                this.dataGridView2.Columns[0].HeaderText = "Product CategorialNumber";
                this.dataGridView2.Columns[1].HeaderText = "Amount";
            }
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;

        }

        private void SO_Products_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.PRODUCTTYPES' table. You can move, or remove it, as needed.
            this.pRODUCTTYPESTableAdapter.Fill(this.sAD_1DataSet.PRODUCTTYPES);
            // TODO: This line of code loads data into the 'sAD_1DataSet.PRODUCTS' table. You can move, or remove it, as needed.
            //this.pRODUCTSTableAdapter.Fill(this.sAD_1DataSet.PRODUCTS);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    chosenPID = int.Parse(row.Cells[1].Value.ToString());
                    productID_txt.Text = chosenPID.ToString();
                    productName_txt.Text = row.Cells[2].Value.ToString();
                    amount_txt.Text = "";
            }
            catch { }
        }


            private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                this.chosenID = int.Parse(row.Cells[0].Value.ToString());
            }
            catch { }
        }


        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            int count = productTypesDict.Count();

            while (count > i)
            {
                if (productTypesDict.ElementAt(i).Key.getCatNumber() == this.chosenID)
                {
                    ProductType PT = productTypesDict.ElementAt(i).Key;
                    this.temp.Remove(PT.getCatNumber());
                    productTypesDict.Remove(PT);
                    if (temp.Count() != 0)
                    {
                        BindingSource _bindingSource = new BindingSource();//????
                        dataGridView2.DataSource = _bindingSource;
                        _bindingSource.DataSource = temp;
                        this.dataGridView2.Columns[0].HeaderText = "Product CategorialNumber";
                        this.dataGridView2.Columns[1].HeaderText = "Amount";
                    }
                    else
                    {
                        temp.Add(0, 0);
                        BindingSource _bindingSource = new BindingSource();
                        dataGridView2.DataSource = _bindingSource;
                        _bindingSource.DataSource = temp;
                        this.dataGridView2.Columns[0].HeaderText = "Product CategorialNumber";
                        this.dataGridView2.Columns[1].HeaderText = "Amount";
                    }

                    break;
                }
                else
                {
                    i = i + 1;
                }

            }


        }

        private void pid2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void addProduct_button_Click(object sender, EventArgs e)
        {
            int amount = 0;
            try
            {
                amount = int.Parse(amount_txt.Text);
            }
            catch (Exception ex) { }

            try
            {
                if (amount > 0)
                {
                    ProductType PT = Program.findProductType(int.Parse(productID_txt.Text));
                    productTypesDict.Add(PT, amount);

                    if (temp.Count() == 1 && temp.ContainsKey(0)) {
                        temp.Remove(0);
                        temp.Add(PT.getCatNumber(), amount);
                    }
                    else {
                        temp.Add(PT.getCatNumber(), amount);
                    }
                    productID_txt.Clear();
                    productName_txt.Clear();
                    amount_txt.Clear();

                    MessageBox.Show("Product was added");

                    BindingSource _bindingSource = new BindingSource();
                    dataGridView2.DataSource = _bindingSource;
                    _bindingSource.DataSource = temp;
                    this.dataGridView2.Columns[0].HeaderText = "Product CategorialNumber";
                    this.dataGridView2.Columns[1].HeaderText = "Amount";
                }
                else
                {
                    MessageBox.Show("Could not add this product, you must choose amount (atleast 1 product)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add this product, check your product id");
            }


        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            Program.tempSOProducts = productTypesDict;//??
            if (Program.SO.Count()!=0) {
                supplierOrderChoosen = Program.SO.ElementAt(0);
                supplierOrderChoosen.setProducts(Program.tempSOProducts);

            }
            else { 
            supplierOrderChoosen.setProducts(Program.tempSOProducts);
            }
            Program.tempSOProducts.Clear();
            new SupplierOrdersForm().Show();
            this.Hide();
        }

        private void amount_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            string searchVal = searchbar.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select SB.supplierID, PT.categorialNumber, PT.name, PT.shelfLifeDays, SB.pricePerUnit " +
                "                                       from SUPPLIERBIDS as SB JOIN PRODUCTTYPES AS PT ON SB.categorialNumber = PT.categorialNumber" +
                "                                       where PT.categorialNumber like '%" + searchVal + "%' or PT.name like '%" + searchVal + "%'", connection);
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

        private void dataGridView2_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                this.chosenID = int.Parse(row.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productID_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
