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
using System.Linq;

namespace BiotestCompany
{
    public partial class ChatMainForm : Form
    {
        private User user;
        private SqlConnection con;
        private DataTable dt;
        private Chat chosenChat;
        public ChatMainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            Messages_txt.ScrollBars = ScrollBars.Vertical;

            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");
            SqlDataAdapter adapt = new SqlDataAdapter("select C.chatID, C.description, C.manager, C.[name], c.openingDT from CHATS as C join CHATPARTS as P on C.ChatID = P.ChatID where P.chatUser =" + this.user.getID(), connection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChatMainForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1 && rowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                this.chosenChat = Program.findChat(int.Parse(row.Cells[0].Value.ToString()));
                Messages_txt.Text = getAllMessagesCont(chosenChat);
                times_txt.Text = getAllMessagesTime(chosenChat);
                label4.Show();
                label5.Show();
                label7.Show();
                label6.Show();
                label6.Text = row.Cells[3].Value.ToString();
                if (row.Cells[1].Value.ToString() == "")
                {
                    label5.Text = "no description";
                }
                else
                {
                    label5.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string getAllMessagesCont(Chat chat)
        {
            List<Message> sortedMessages = chat.getMessages().OrderBy(M => M.getMessageDT()).ToList();
            string temp = "";
            string final = "";
            foreach (Message M in sortedMessages)
            {
                if (M != null)
                {
                    temp = M.getSentBy().getFirstName() + " " + M.getSentBy().getLastName() + ": " + M.getContent();
                    final += ('\n' + temp);
                    final = final.Replace("\n", System.Environment.NewLine);
                }
            }
            return final;
        }

        private string getAllMessagesTime(Chat chat)
        {
            List<Message> sortedMessages = chat.getMessages().OrderBy(M => M.getMessageDT()).ToList();
            string temp = "";
            string final = "";
            foreach (Message M in sortedMessages)
            {
                if (M != null)
                {
                    temp = M.getMessageDT().ToString();
                    final += ('\n' + temp);
                    final = final.Replace("\n", System.Environment.NewLine);
                }
            }
            return final;
        }

        private void Messages_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Send_Butt_Click(object sender, EventArgs e)
        {
            if (NewM_txt.Text.Length > 0)
            {

                new Message(user, NewM_txt.Text, null, null, chosenChat.getID(), true);
                Messages_txt.Text = getAllMessagesCont(chosenChat);
                times_txt.Text = getAllMessagesTime(chosenChat);
                NewM_txt.Text = "";
            }

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Messages_txt.SelectionStart = e.NewValue;
            Messages_txt.ScrollToCaret();
            times_txt.SelectionStart = e.NewValue;
            times_txt.ScrollToCaret();
        }

        public void updateChats()
        {
            SqlCommand c = new SqlCommand();

            SQL_CON SC = new SQL_CON();
            SqlConnection connection = new SqlConnection("Data Source = IEMDBS; Initial Catalog = SAD_1; Integrated Security = True");

            SqlDataAdapter adapt = new SqlDataAdapter("select C.chatID, C.description, C.manager, C.[name], c.openingDT from CHATS as C join CHATPARTS as P on C.ChatID = P.ChatID where P.chatUser =" + this.user.getID(), connection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void newChat_Butt_Click(object sender, EventArgs e)
        {
            new ChatNewChatForm(user.getID(), this).Show();
        }

        private void newGroup_Butt_Click(object sender, EventArgs e)
        {
            new ChatNewMultiChatForm(user.getID(), this).Show();
        }

        private void times_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
