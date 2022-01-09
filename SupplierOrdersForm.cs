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
    public partial class SupplierOrdersForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private int chosenSOID;
        private Dictionary<ProductType, int> productsList = new Dictionary<ProductType, int>();
        public SupplierOrdersForm()
        {
            InitializeComponent();

            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from SUPPLIERORDERS", connection);
            dt = new DataTable();
            adapt.Fill(dt);
            sUPPLIERORDERSDataGridView.DataSource = dt;

            puncValue.Text = "0";
            qualValue.Text = "0";

            puncValue.Hide();
            qualValue.Hide();
            punctualityScore.Hide();
            qualityScore.Hide();
            trackBar1.Hide();
            trackBar2.Hide();
            //add_button.Hide();
            if (Program.checkRole(Program.LoggedIn.getEmail()) == "Manager" || Program.checkRole(Program.LoggedIn.getEmail()) == "Manager")
            {
                //add_button.Show();
            }
            sUPPLIERORDERSDataGridView.ReadOnly = true;
        }

        private void sUPPLIERORDERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sUPPLIERORDERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_1DataSet);

        }

        private void SupplierOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.SUPPLIERORDERS' table. You can move, or remove it, as needed.
            this.sUPPLIERORDERSTableAdapter.Fill(this.sAD_1DataSet.SUPPLIERORDERS);



        }

        private void sUPPLIERORDERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = sUPPLIERORDERSDataGridView.Rows[rowIndex];
                if (rowIndex > -1 && rowIndex < sUPPLIERORDERSDataGridView.Rows.Count - 1) //update order
                {
                    arrivalDate_picker.Enabled = true;
                    puncValue.Show();
                    qualValue.Show();
                    punctualityScore.Show();
                    qualityScore.Show();
                    orderID_txt.Show();

                    chosenSOID = int.Parse(row.Cells[0].Value.ToString());
                    orderID_txt.Text = row.Cells[0].Value.ToString();
                    orderDate_picker.Value = Program.stringToDate(row.Cells[1].Value.ToString());
                    arrivalDate_picker.Value = Program.stringToDate(row.Cells[2].Value.ToString());
                    shippingCost_txt.Text = row.Cells[3].Value.ToString();
                    orderValue_txt.Text = row.Cells[4].Value.ToString();
                    supplierID_Box.Text = row.Cells[7].Value.ToString();
                    trackBar1.Value = int.Parse(row.Cells[5].Value.ToString());
                    trackBar2.Value = int.Parse(row.Cells[6].Value.ToString());

                    if (Program.checkRole(Program.LoggedIn.getEmail()) == "Manager" && puncValue.Text != "0" && qualValue.Text != "0") //only manager can update scores
                    {
                        trackBar1.Show();
                        trackBar2.Show();
                    }
                    else if (puncValue.Text == "0" && qualValue.Text == "0") //everyone can insert scores
                    {
                        trackBar1.Show();
                        trackBar2.Show();
                    }
                    else
                    {
                        trackBar1.Hide();
                        trackBar2.Hide();
                    }
                }
                else //add new order
                {
                    arrivalDate_picker.Enabled = false;
                    puncValue.Hide();
                    qualValue.Hide();
                    punctualityScore.Hide();
                    qualityScore.Hide();
                    trackBar1.Hide();
                    trackBar2.Hide();
                    orderID_txt.Hide();

                    chosenSOID = 0;
                    orderID_txt.Text = "";
                    arrivalDate_picker.Value = DateTime.Now;
                    shippingCost_txt.Text = "";
                    orderValue_txt.Text = "";
                    supplierID_Box.Text = "";
                    trackBar1.Value = 0;
                    trackBar2.Value = 0;

                    orderDate_picker.Value = Program.stringToDate(DateTime.Now.ToString());
                }
            }
            catch { }
        }

        private void updateScore_Click(object sender, EventArgs e)
        {
            SupplierOrder SO = Program.findMySupplierOrder(chosenSOID);
            Console.WriteLine(SO.getOrderID());
            SO.setPunctualityScore(double.Parse(trackBar1.Value.ToString()));
            SO.setQualityScore(double.Parse(trackBar2.Value.ToString()));

            SO.updateSupplierOrder(); //if score was updated, consider split to another form
            SearchBar_txt_TextChanged(sender, e); //to refresh the form's table
            Console.WriteLine("SO No." + SO.getOrderID() + ": " + SO.getPunctualityScore() + ", " + SO.getQualityScore());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            puncValue.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            puncValue.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            qualValue.Text = trackBar2.Value.ToString();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            qualValue.Text = trackBar2.Value.ToString();
        }

        private void SearchBar_txt_TextChanged(object sender, EventArgs e)
        {
            string searchVal = SearchBar_txt.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * " +
                "                                       from SUPPLIERORDERS" +
                "                                       where supplierOrderID like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                sUPPLIERORDERSDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please fill all fields, in order to apply changes");
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void sUPPLIERORDERSDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sUPPLIERORDERSDataGridView_CellDoubleClick(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            { //ASSIGN SO ID!
                Dictionary<ProductType, int> temp = new Dictionary<ProductType, int>();
                Supplier S = Program.findMySupplier(int.Parse(supplierID_Box.Text.ToString()));
                SupplierOrder SO = new SupplierOrder(Program.assignSuppOrderID(), DateTime.Now, DateTime.Now, double.Parse(shippingCost_txt.Text), double.Parse(orderValue_txt.Text), 0, 0, S, temp, true);
                Program.SO.Add(SO);
                // SupplierOrder SO = new SupplierOrder(Program.assignSuppOrderID(), DateTime.Now, DateTime.Now, double.Parse(shippingCost_txt.Text), double.Parse(orderValue_txt.Text), 0, 0, S, null, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SearchBar_txt_TextChanged(sender, e);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierOrder SO = Program.findMySupplierOrder(chosenSOID);
                SO.setArrivalDate(arrivalDate_picker.Value);
                SO.setShippingCost(double.Parse(shippingCost_txt.Text.ToString()));
                SO.setShippingCost(double.Parse(shippingCost_txt.Text.ToString()));
                SO.setSupplier(int.Parse(supplierID_Box.Text.ToString()));
                SO.setPunctualityScore(double.Parse(trackBar1.Value.ToString()));
                SO.setQualityScore(double.Parse(trackBar2.Value.ToString()));

                SO.updateSupplierOrder(); //if score was updated, consider split to another form
                SearchBar_txt_TextChanged(sender, e); //to refresh the form's table
                clear_fields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes. ", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear_fields()
        {
            orderID_txt.Text = "";
            shippingCost_txt.Text = "";
            orderValue_txt.Text = "";
            supplierID_Box.Text = "";
        }
        private void qualValue_Click(object sender, EventArgs e)
        {

        }
        public void setProductsList(Dictionary<ProductType, int> list)
        {
            this.productsList = list;
        }

        private void addProducts_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(chosenSOID.GetType());
            if (chosenSOID.GetType() != typeof(int)) {
                MessageBox.Show("blabla");
            }
            else { 
            try
            {
                if (chosenSOID == 0)
                {
                    Program.tempSOProducts = new Dictionary<ProductType, int>();
                }
                else
                {
                    //Program.tempSOProducts = Program.FindMySupplierOrder(chosenSOID).set// alon?
                }
                this.Hide();//??

                new SO_Products_Form(chosenSOID, int.Parse(supplierID_Box.Text.ToString())).Show();
            }
            catch {  }
            }
        }

        private void sUPPLIERORDERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDate_picker_ValueChanged(object sender, EventArgs e)
        {


        }

        private void arrivalDate_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Out_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBar_txt.Text = "";
        }

        private void orderID_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
