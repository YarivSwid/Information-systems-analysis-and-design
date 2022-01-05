using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    public class Message
    {
        private User sentBy { get; }
        private DateTime messageDT { get; }
        private string content { get; } // we assume that we cant edit messages
        private string attachedPhoto { get; }
        private Message asaResponseTo { get; }
        private int chatID;

        public Message(User sentBy, string content, DateTime messageDT, string attachedPhoto, Message asaResponseTo, int chatID, Boolean isNew) // constructor for inits
        {
            this.sentBy = sentBy;
            this.messageDT = messageDT;
            this.content = content;
            this.attachedPhoto = attachedPhoto;
            this.asaResponseTo = asaResponseTo;
            this.chatID = chatID;
            if (isNew)
            {
                //this.createMessage(); its inits. dont re open it. to be deleted.
                Program.messages.Add(this);
                Program.findChat(chatID).getMessages().Add(this);
            }
        }

        public Message(User sentBy, string content, string attachedPhoto, Message asaResponseTo, int chatID, Boolean isNew) // constructor for GUI
        {
            this.sentBy = sentBy;
            this.messageDT = DateTime.Now;
            this.content = content;
            this.attachedPhoto = attachedPhoto;
            this.asaResponseTo = asaResponseTo;
            this.chatID = chatID;
            if (isNew)
            {
                this.createMessage();
                Program.messages.Add(this);
                Program.findChat(chatID).getMessages().Add(this);
            }
        }

        // getters & setters:

        public User getSentBy()
        {
            return this.sentBy;
        }
        public DateTime getMessageDT()
        {
            return this.messageDT;
        }
        public string getContent()
        {
            return this.content;
        }
        public Message getAsaResponseTo()
        {
            return this.asaResponseTo;
        }
        public int getChatID()
        {
            return this.chatID;
        }

        public void createMessage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddMessage @sentBy, @messageDT, @content, @attachedPhoto, @asaResponseToUser, @asaResponseToDT, @partOfChat";
            c.Parameters.AddWithValue("@sentBy", this.sentBy.getID());
            c.Parameters.AddWithValue("@messageDT", this.messageDT);
            c.Parameters.AddWithValue("@content", this.content);
            c.Parameters.AddWithValue("@attachedPhoto", DBNull.Value);  //this.attachedPhoto);
            c.Parameters.AddWithValue("@asaResponseToUser", DBNull.Value); //this.getAsaResponseTo().getSentBy().getID()); // need to insert USER ID, so retrieve the message, then the User that sent it, then the user's id.
            c.Parameters.AddWithValue("@asaResponseToDT", DBNull.Value); //this.getAsaResponseTo().getMessageDT());
            c.Parameters.AddWithValue("@partOfChat", this.chatID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateMessage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateMessage @sentBy, @messageDT, @content, @attachedPhoto, @asaResponseToUser, @asaResponseToDT, @partOfChat";
            c.Parameters.AddWithValue("@sentBy", this.sentBy);
            c.Parameters.AddWithValue("@messageDT", this.messageDT);
            c.Parameters.AddWithValue("@content", this.content);
            c.Parameters.AddWithValue("@attachedPhoto", this.attachedPhoto);
            c.Parameters.AddWithValue("@asaResponseToUser", this.getAsaResponseTo().getSentBy().getID()); // need to insert USER ID, so retrieve the message, then the User that sent it, then the user's id.
            c.Parameters.AddWithValue("@asaResponseToDT", this.getAsaResponseTo().getMessageDT());
            c.Parameters.AddWithValue("@partOfChat", this.chatID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}