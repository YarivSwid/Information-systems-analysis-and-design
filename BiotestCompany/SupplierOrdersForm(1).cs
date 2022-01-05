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
            label3.Hide();
            trackBar1.Hide();
            trackBar2.Hide();
            updateScore.Hide();
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
            puncValue.Show();
            qualValue.Show();
            punctualityScore.Show();
            qualityScore.Show();
            label3.Show();
            trackBar1.Show();
            trackBar2.Show();
            updateScore.Show();

            int rowIndex = e.RowIndex;
            DataGridViewRow row = sUPPLIERORDERSDataGridView.Rows[rowIndex];
            chosenSOID = int.Parse(row.Cells[0].Value.ToString());

            label3.Text = "Rate Order No. " + chosenSOID + " by supplier " + int.Parse(row.Cells[7].Value.ToString()) + ":";
        }

        private void updateScore_Click(object sender, EventArgs e)
        {
            SupplierOrder SO = Program.FindMySupplierOrder(chosenSOID);
            Console.WriteLine(SO.getOrderID());
            SO.setPunctualityScore(double.Parse(trackBar1.Value.ToString()));
            SO.setQualityScore(double.Parse(trackBar2.Value.ToString()));

            SO.updateSupplierOrder();
            SearchBar_txt_TextChanged(sender, e);
            Console.WriteLine("SO No." + SO.getOrderID() + ": " + SO.getPunctualityScore() + ", " + SO.getQualityScore());
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            qualValue.Text = trackBar2.Value.ToString();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
