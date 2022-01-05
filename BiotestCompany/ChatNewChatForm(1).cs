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
    public partial class ChatNewChatForm : Form
    {
        private SqlConnection con;
        private DataTable dt;
        private User chosen;
        private int userID;
        private ChatMainForm aba;
        public ChatNewChatForm(int userID, ChatMainForm aba)
        {
            InitializeComponent();
            this.userID = userID;
            this.aba = aba;
            label2.Text = "";
            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select userID, joinDate, firstName, lastName, birthday, serialID, Email, role from dbo.USERS where role != 'Former' and userID != "+userID , connection);
            dt = new DataTable();
            adapt.Fill(dt);
            uSERSDataGridView.DataSource = dt;
        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sAD_1DataSet);

        }

        private void ChatNewChatForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_1DataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.sAD_1DataSet.USERS);

        }

        private void uSERSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1 && rowIndex < uSERSDataGridView.Rows.Count - 1)
            {
                DataGridViewRow row = uSERSDataGridView.Rows[rowIndex];
                chosen = Program.FindMyUser_ByEmail((row.Cells[2].Value.ToString()));
                label2.Text = "You chose: " + (row.Cells[1].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(chosen == null)
            {
                MessageBox.Show("You chose no one \n Are you drunk?", "Oops!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                new ChatMainForm(Program.FindMyUser(userID)).Show();
            }
            else
            {
                List <User> u = new List<User>();
                u.Add(chosen);
                u.Add(Program.FindMyUser(userID));
                Chat C = new Chat(Program.assignChatID(), chosen.getFirstName() + chosen.getLastName(), DateTime.Now, "", Program.FindMyUser(userID), u, new List<Message>(), true);
               // C.createDualChatParts(userID, chosen.getID());
                this.aba.updateChats();
                this.Hide();
            }
        }

        private void uSERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
