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
    public partial class ChatNewMultiChatForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private int userID;
        private ChatMainForm aba;
        private List<User> chosens;
        public ChatNewMultiChatForm(int userID, ChatMainForm aba)
        {
            InitializeComponent();
            this.userID = userID;
            this.aba = aba;
            chosens = new List<User>();
            label2.Text = "You chose: \n";
            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select userID, joinDate, firstName, lastName, birthday, serialID, Email, role from dbo.USERS where role != 'Former' and userID != " + userID, connection);
            dt = new DataTable();
            adapt.Fill(dt);
            uSERSDataGridView.DataSource = dt;
            uSERSDataGridView.ReadOnly = true;

        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_1DataSet);

        }

        private void ChatNewMultiChatForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.sAD_1DataSet.USERS);

        }
        private void uSERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = uSERSDataGridView.Rows[rowIndex];
            Boolean isThere = false;
            if (rowIndex > -1 && rowIndex < uSERSDataGridView.Rows.Count - 1)
            {
                foreach (User U in chosens)
                {
                    if (U.getEmail() == row.Cells[2].Value.ToString())
                    {
                        isThere = true;
                    }
                }
                if (isThere == false)
                {
                    chosens.Add(Program.findMyUser_ByEmail((row.Cells[2].Value.ToString())));
                    string final = label2.Text + "\n" + row.Cells[0].Value.ToString() + row.Cells[1].Value.ToString();
                    label2.Text = final;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chosens.Count == 0)
            {
                MessageBox.Show("You chose no one \n Are you drunk?", "Oops!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                new ChatMainForm(Program.findMyUser(userID)).Show();
            }
            else if (name_txt.Text == "" || disc_txt.Text == "")
            {
                MessageBox.Show("You MUST add a name and description to the group", "Oops!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chosens.Add(Program.findMyUser(userID));
                Chat C = new Chat(Program.assignChatID(), name_txt.Text, DateTime.Now, disc_txt.Text, Program.findMyUser(userID), chosens, new List<Message>(), true);
                this.aba.updateChats();
                this.Hide();
            }
        }

        private void uSERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
