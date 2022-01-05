
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    public class Chat
    {
        private int chatID;
        private string name;
        private DateTime openingDT;
        private string description;
        private User creator;
        private List<User> participants; // update when user joins/leaves chat
        private List<Message> messages; // take care of it
        
        public Chat(int chatID, string name, DateTime openingDT, string description, User creator, List<User> participants, List<Message> messages, Boolean isNew)
        {
            this.chatID = chatID;
            this.name = name;
            this.openingDT = openingDT;
            this.description = description;
            this.creator = creator;
            this.messages = messages;
            this.participants = participants;
            if (isNew)
            {
                this.createChat();
                Program.chats.Add(this);
            }

        }
        public int giveMe()
        {
            int result = this.openingDT.Year * 100000 + this.openingDT.Month * 1000
                        + this.openingDT.Day * 100 + this.openingDT.Hour * 10 + this.openingDT.Minute + this.openingDT.Second;
            return result;
        }
        public List<Message> getMessages()
        {
            return this.messages;
        }
        public int getID()
        {
            return this.chatID;
        }
        public string getName()
        {
            return this.name;
        }
        public DateTime getOpeningDT()
        {
            return this.openingDT;
        }
        public string getDescription()
        {
            return this.description;
        }
        public User getUser()
        {
            return this.creator;
        }
        public void setName(string newName)
        {
            this.name = newName;
        }
        public void setDescription(string newDescription)
        {
            this.description = newDescription;
        }

        public void createChat()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddChat @chatID,@name,@openingDT,@description,@manager"; // ןגם להוסיף מנג'ר
            c.Parameters.AddWithValue("@chatID", this.chatID);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@openingDT", this.openingDT);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@manager", this.creator.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            SqlCommand a = new SqlCommand();
            string text = "INSERT INTO dbo.CHATPARTS VALUES ";
            foreach (User U in participants)
            {
                text = text + "(" + chatID + "," + U.getID() + "),";
            }
            text = text.Substring(0, text.Length-1);
            a.CommandText = text;
            SC.execute_non_query(a);
        }
        public void updateChat()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateChat @ID, @name, @openingDT, @description, @manager"; // ןגם להוסיף מנג'ר
            c.Parameters.AddWithValue("@chatID", this.chatID);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@openingDT", this.openingDT);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@manager", this.creator.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
            public void deleteUser() // should we delete this delelete ? :)()))))))))))))))
        {
            Program.chats.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.DeleteChat @id";
            c.Parameters.AddWithValue("@id", this.chatID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void createDualChatParts(int f, int s)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "INSERT INTO dbo.CHATPARTS VALUES ("+chatID+","+s+"),("+chatID+", "+f+")";
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}