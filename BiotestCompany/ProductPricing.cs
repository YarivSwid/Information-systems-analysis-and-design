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
    public partial class ProductPricingForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private double catNum;
        private Boolean needManualy;
        private Boolean manual;

        public void setCatNum(double n)
        {
            this.catNum = n;
        }
        public ProductPricingForm()
        {
            InitializeComponent();
            method_cmb.SelectedIndex = 0;
            createGrid();
            pRODUCTTYPESDataGridView.ReadOnly = true;
            manual = false;

        }
        public void createGrid()
        {
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from PRODUCTTYPES", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            pRODUCTTYPESDataGridView.DataSource = dt;

            pRODUCTTYPESDataGridView.Columns[0].HeaderText = "Category Num.";
            pRODUCTTYPESDataGridView.Columns[1].HeaderText = "Product";
            pRODUCTTYPESDataGridView.Columns[2].HeaderText = "Shelf Life (days)";
            pRODUCTTYPESDataGridView.Columns[3].HeaderText = "Temperture (c)";
            pRODUCTTYPESDataGridView.Columns[4].HeaderText = "Weight (kg)";
            pRODUCTTYPESDataGridView.Columns[5].HeaderText = "Price";
        }

        private void pRODUCTTYPESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCTTYPESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_1DataSet);

        }

        private void ProductPricingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.PRODUCTTYPES' table. You can move, or remove it, as needed.
            this.pRODUCTTYPESTableAdapter.Fill(this.sAD_1DataSet.PRODUCTTYPES);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pRODUCTTYPESDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBar_txt_TextChanged(object sender, EventArgs e)
        {
            string searchVal = SearchBar_txt.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from producttypes" +
                "                                       where name like'%" + searchVal + "%' or categorialNumber like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                pRODUCTTYPESDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please fill all fields, in order to apply changes");
            }
        }
        private void pRODUCTTYPESDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                needManualy = false;
                int rowIndex = e.RowIndex;
                DataGridViewRow row = pRODUCTTYPESDataGridView.Rows[rowIndex];
                string catNum = row.Cells[0].Value.ToString();
                this.setCatNum(double.Parse(catNum));
                supPrice_lbl.Text = getSupplierPrice(catNum) + " $";
                prodName_lbl.Text = "Product: " + row.Cells[1].Value.ToString();
                shelfLife_lbl.Text = row.Cells[2].Value.ToString();
                temp_lbl.Text = row.Cells[3].Value.ToString();
                weight_lbl.Text = row.Cells[4].Value.ToString();
            }
            catch { }
        }

        private string getSupplierPrice(string catNum)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetSupplierPrice @catNum";
            c.Parameters.AddWithValue("@catNum", catNum);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            string price;

            rdr.Read();
            try
            {
                price = rdr.GetValue(0).ToString();
            }
            catch
            {
                price = "not availlable";
                needManualy = true;
            }
            return price;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void clear_butt_Click(object sender, EventArgs e)
        {
            SearchBar_txt.Text = "";
        }

        private void smartPricing_butt_Click(object sender, EventArgs e)
        {
            switchModes(false);
        }

        private void manualPricing_butt_Click(object sender, EventArgs e)
        {
            switchModes(true);
        }
        private void switchModes(Boolean flag) // true=manual, false=smart
        {
            manual = flag;
            manualPricing_lbl.Visible = flag;
            enterPrice_txt.Visible = flag;
            setPrice_butt.Visible = flag;

            lbl5.Visible = !flag;
            lbl6.Visible = !flag;
            lbl7.Visible = !flag;
            lbl8.Visible = !flag;
            shippingCost_txt.Visible = !flag;
            expSales_txt.Visible = !flag;
            revenue_txt.Visible = !flag;
            method_cmb.Visible = !flag;
            calcPrice_butt.Visible = !flag;
        }
        private void manualPricing_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shippingCost_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void shippingCost_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || (shippingCost_txt.Text.Length > 20))
            {
                e.Handled = true;
            }
        }

        private void expSales_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || (expSales_txt.Text.Length > 20))
            {
                e.Handled = true;
            }
        }

        private void revenue_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || (revenue_txt.Text.Length > 20))
            {
                e.Handled = true;
            }
        }

        private void enterPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || (enterPrice_txt.Text.Length > 20))
            {
                e.Handled = true;
            }
        }

        private void revenue_txt_Leave(object sender, EventArgs e)
        {
            //if(double.Parse(revenue_txt.Text)>100)

        }

        private void calcPrice_butt_Click(object sender, EventArgs e)
        {
            if (prodName_lbl.Text == "")
            {
                MessageBox.Show("Please choose product first", "Oops!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (manual == true) // manual pricing
            {
                if (enterPrice_txt.Text == "")
                {
                    MessageBox.Show("Please enter price", "Oops!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult res = MessageBox.Show("Price for " + prodName_lbl.Text + " will be " + enterPrice_txt.Text + " $. Confirm?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes)
                    {
                        confirmPrice(double.Parse(enterPrice_txt.Text));
                    }
                }
            }

            else // smart pricing
            {
                if (noMissingDetails())
                {
                    calculatePrice(method_cmb.Text);
                }
                else
                {
                    MessageBox.Show("Some details are missing", "Oops!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private Boolean noMissingDetails()
        {
            if ((shippingCost_txt.Text != "") && (expSales_txt.Text != "") && (revenue_txt.Text != ""))
                return true;
            return false;
        }
        private void calculatePrice(string method)
        {
            if (needManualy == true)
            {
                MessageBox.Show("Lacking supplier price, please price manualy", "Oops!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                switchModes(true);

            }
            else
            {
                string supplierPrice = supPrice_lbl.Text.Substring(0, supPrice_lbl.Text.Length - 1);
                double x1 = double.Parse(supplierPrice.ToString());
                double x2 = double.Parse(shelfLife_lbl.Text.ToString());
                double x3 = double.Parse(temp_lbl.Text.ToString());
                double x4 = double.Parse(weight_lbl.Text.ToString());
                double x5 = double.Parse(shippingCost_txt.Text.ToString());
                int x6 = int.Parse(expSales_txt.Text.ToString());
                double x7 = double.Parse(revenue_txt.Text.ToString());
                double price = 0;

                if (method == "Default")
                    price = x1 * (1 + x7);
                if (method == "Short shelf life emphasis")
                    price = x1 * (1 + x7 + Math.Pow(x2, 0.5));
                if (method == "Shipping cost emphasis")
                    price = (x1 + x5) * (1 + x7);
                if (method == "Small volume emphasis")
                    price = x1 * (1 + x7 + 100 / x6);
                price = Math.Ceiling(price);
                DialogResult res = MessageBox.Show("Price for " + prodName_lbl.Text + " will be " + price + " $. Confirm?", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    confirmPrice(price);
                }
            }
        }

        public void confirmPrice(double price)
        {
            ProductType prod = Program.productTypes.Find(P => P.getCatNumber() == catNum);
            prod.setPrice(price);
            Boolean flag = true;
            try
            {
                prod.updatePrice();
            }
            catch
            {
                flag = false;
                Console.WriteLine("Price update failed");
            }
            if (flag)
            {
                MessageBox.Show("Price updated successfully", "Success!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ProductPricingForm new_form = new ProductPricingForm();
                new_form.Show();
                clearAll();
            }
        }
        public void clearAll()
        {
            prodName_lbl.Visible = false;
            supPrice_lbl.Visible = false;
            shelfLife_lbl.Visible = false;
            temp_lbl.Visible = false;
            weight_lbl.Visible = false;
            enterPrice_txt.Text = "";
            shippingCost_txt.Text = "";
            expSales_txt.Text = "";
            revenue_txt.Text = "";
            method_cmb.Text = "Default";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Out_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void setPrice_butt_Click(object sender, EventArgs e)
        {
            if(enterPrice_txt.Text=="")
            {
                MessageBox.Show("Please enter price", "Oops!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double price = double.Parse(enterPrice_txt.Text.ToString());
            confirmPrice(price);
        }
    }
}
