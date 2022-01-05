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
    public partial class CRUDusersForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private int chosenID;
        public CRUDusersForm()
        {
            InitializeComponent();
            
           
            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select userID, joinDate, firstName, lastName, birthday, serialID, Email, role from USERS" , connection);
            dt = new DataTable();
            adapt.Fill(dt);
            uSERSDataGridView.DataSource = dt;
            uSERSDataGridView.ReadOnly = true;
            Role_Box.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            Role_Box.DataSource = Enum.GetValues(typeof(Role));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biotestDataSet);

        }

        private void uSERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uSERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1 && rowIndex < uSERSDataGridView.Rows.Count - 1)
            {
                DataGridViewRow row = uSERSDataGridView.Rows[rowIndex];
                chosenID = int.Parse(row.Cells[0].Value.ToString());
                Firstname_txt.Text = row.Cells[2].Value.ToString();
                Lastname_txt.Text = row.Cells[3].Value.ToString();
                Serial_txt.Text = row.Cells[5].Value.ToString();
                Email_txt.Text = row.Cells[6].Value.ToString();
                dateTimePicker1.Value = Program.stringToDate(row.Cells[4].Value.ToString());
                Role_Box.Text = row.Cells[7].Value.ToString();
            }
        }
        // Program.FindMyUser(int.Parse(row.Cells[0].Value.ToString())).getRole();
        private void searchUser_butt_Click(object sender, EventArgs e)
        {
            string searchVal = SearchBar_txt.Text;
            SqlCommand c = new SqlCommand();
            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select userID, joinDate, firstName, lastName, birthday, serialID, Email, role " +
                "                                       from USERS" +
                "                                       where firstName like'%" + searchVal + "%' or lastName like'%" + searchVal + "%'", connection);
            try
            {
                dt = new DataTable();
                adapt.Fill(dt);
                uSERSDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please fill all fields, in order to apply changes");
            }
        }


        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            try
            {
                Role R = (Role)Enum.Parse(typeof(Role), Role_Box.Text.ToString());
                User U = new User(Program.assignUserID(), DateTime.Now, Firstname_txt.Text, Lastname_txt.Text, dateTimePicker1.Value, int.Parse(Serial_txt.Text), Email_txt.Text, R, "no pic", true);
                searchUser_butt_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields, in order to apply changes", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            Role R = (Role)Enum.Parse(typeof(Role), Role_Box.Text.ToString());
            User U = Program.findMyUser(chosenID);
            U.setFirstName(Firstname_txt.Text);
            U.setLastName(Lastname_txt.Text);
            U.setBirthday(dateTimePicker1.Value);
            U.setEmail(Email_txt.Text);
            U.setSerialID(int.Parse(Serial_txt.Text));
            U.setRole(R);
            //  U.setProfilePicture();
            U.updateUser();
            searchUser_butt_Click(sender, e);
        }
        private void serial_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBar_txt.Text = "";
        }

        private void Role_Box2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Out_Butt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuManagerForm().Show();
        }

        private void uSERSDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime dt = this.dateTimePicker1.Value.Date;
            if (dt >= DateTime.Now.Date)
            {
                MessageBox.Show("Please choose only passed dates", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Serial_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}